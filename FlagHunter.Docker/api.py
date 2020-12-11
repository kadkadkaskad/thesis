import uuid, json, requests, docker
from flask import Flask, jsonify, request
from flask_restful import Resource, Api

app = Flask(__name__)
api = Api(app)

client = docker.DockerClient(base_url='tcp://172.16.0.100:2375')
#low_level_client = docker.APIClient(base_url='tcp://172.16.10.10:2375') ?? dunno yet

defaultPortTag = "traefik.http.services.<name>.loadbalancer.server.port"

def CreateNewEnvironmentId():
    env_id = str(uuid.uuid4())
    return env_id.replace('-','')

def ListServices(labels):
    return client.services.list(filters=labels)

class ListServices(Resource):
    def get(self):
        services = client.services.list()
        service_list = list()
        for s in services:
            service_list.append(s.name)
        return jsonify(service_list)
        
class ServiceIdByLabels(Resource):
    def post(self):

        json_data = request.get_json(force=True)
        filters = {
            "label" : "student_id=" + json_data['s_id'],
            "label" : "test_id=" + json_data['t_id'],
        }

        res = client.services.list(filters=filters)
        service = res.pop()
        return service.name

class InitializeContainerEnvironment(Resource):
    def post(self):
        json_data = request.get_json(force=True)
        student_id = json_data['s_id']
        test_id = json_data['t_id']
        image = json_data['image']
        backend_port = json_data['backend_port']
        env_id= CreateNewEnvironmentId()
        env_labels = {
            "traefik.port" : "80",
            defaultPortTag.replace("<name>", env_id) : str(backend_port),
            "student_id" : student_id,
            "test_id" : test_id
        }
        mount = "/home/vagrant/nfs/students/alice/programming2:/home/project:rw"
        service = client.services.create(image, labels=env_labels, name=env_id, networks = [ "traefik-net" ], mounts=[mount])
        
        # Waiting for the routing rule
        status_code = 0 
        while status_code != 200:
            res = requests.get('http://' + env_id + '.traefik')
            status_code = res.status_code
        
        return env_id

class ValidateCTest(Resource):
    def get(self):
        image="frolvlad/alpine-gcc"

        validate_cmd='sh -c "gcc -I/a /b/solve_me.c /a/validate.c -o /a/a.out && /a/a.out"'

        validate_path="/home/vagrant/nfs/validation:/a:rw"
        solution_path="/home/vagrant/nfs/students/alice/programming2:/b:rw"

        service = client.services.create(image, command=validate_cmd, networks = [ "traefik-net" ], mounts=[solution_path, validate_path])
        service_id = service.id

        running=True 
        while running:
            tmp_service = client.services.get(service_id)
            shutdowns = tmp_service.tasks(filters={ "desired-state" : "Shutdown" })
            if len(shutdowns)  > 0:
                logs = tmp_service.logs(stdout=True, stderr=True)
                output = logs.__next__().decode('utf-8')
                if 'Passed' in output: 
                    service.remove()
                    return True
                elif 'Failed' in output:
                    service.remove()
                    return False
                    
        service.remove()
        return False

        

class RemoveContainerEnvironment(Resource):
    def get(self, service_id):
        try:
            service = client.services.get(service_id)
            service.remove()
            return True
        except:
            return False


api.add_resource(InitializeContainerEnvironment, '/api/InitializeContainerEnvironment')
api.add_resource(ListServices, '/api/ListServices')
api.add_resource(RemoveContainerEnvironment, '/api/Service/<string:service_id>/Stop')
api.add_resource(ServiceIdByLabels, '/api/Service')
api.add_resource(ValidateCTest, '/api/ValidateCTest')

if __name__ == '__main__':
    app.run(debug=True, host='0.0.0.0', port = 5555)