import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { User } from '../models/user';
import { FormGroup } from '@angular/forms';
import { map } from 'rxjs/operators';
import { Router } from '@angular/router';
import * as jwt_decode from 'jwt-decode';
import { LoginUser } from '../models/login-user';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private currentUserSubject: BehaviorSubject<User>;
  private currentUser: Observable<User>;

  constructor(private http: HttpClient, private router: Router) {
    this.currentUserSubject = new BehaviorSubject<User>(JSON.parse(localStorage.getItem('currentUser')));
    this.currentUser = this.currentUserSubject.asObservable();
  }

  public get currentUserValue(): User {
      return this.currentUserSubject.value;
  }

  login(username: string, password: string) {
    var body = {
        UserName : username,
        Password : password
    };
    return this.http.post<any>(`${environment.apiUrl}/Auth/Login`, body)
    .pipe(map(res => {
      // login successful if there's a jwt token in the response
      if (res.tokenString) {
          var decoded = jwt_decode(res.tokenString);
          // store user details and jwt token in local storage to keep user logged in between page refreshes
          var user = new User(decoded.unique_name, decoded.role, res.tokenString);
          localStorage.setItem('currentUser', JSON.stringify(user));
          this.currentUserSubject.next(user);
      }
      return decoded;
    }));
  }

  logout() {
    // remove user from local storage to log user out
    localStorage.removeItem('currentUser');
    this.currentUserSubject.next(null);
    this.router.navigate(['/']);
  }
}
