import { Injectable } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { HttpClient, HttpHeaders  } from "@angular/common/http";
import { Observable } from 'rxjs';
// import { User } from '../models/user.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private fb: FormBuilder, private http : HttpClient) {}
  readonly BaseURI = 'http://localhost:5000/api';

  loginModel = this.fb.group({
    userName : "",
    password : ""
  });

  login() {
    var body = {
      UserName : this.loginModel.value.userName,
      Password : this.loginModel.value.password
    };
    return this.http.post(this.BaseURI + '/Auth/Login', body);
  }
}
