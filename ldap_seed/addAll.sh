#! /bin/bash
sleep 5
ldapadd -x -H ldap://ldap_server -D "cn=admin,dc=example,dc=org" -w QWeasd123%QWEasd123% -f /data/ldif/seed.ldif
