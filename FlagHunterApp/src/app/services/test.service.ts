import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Environment } from '../models/environment';
import { StudentTest } from '../models/studentTest';
import { Test } from '../models/test';

@Injectable({
  providedIn: 'root'
})
export class TestService {

  constructor(private http: HttpClient) { }

  getTestById(id: string) {
    return this.http.get<Test>(`${environment.apiUrl}/Test/`+ id)
  }

  getTestDetailsById(testId: string) {
    return this.http.get<Test>(`${environment.apiUrl}/Test/`+ testId);
  }

  startTest(id: string) {
    return this.http.get(`${environment.apiUrl}/Test/` + id + `/Start`, {responseType: 'text'})
  }

  stopTest(testId: string) {
    return this.http.get<boolean>(`${environment.apiUrl}/Test/` + testId + `/Stop`);
  }

  validateCTest(testId: string) {
    console.log(testId)
    return this.http.get<boolean>(`${environment.apiUrl}/Test/` + testId + `/ValidateCTest`);
  }
  
  getEnvironment(testId: string) {
    return this.http.get(`${environment.apiUrl}/Test/` + testId + `/Environment`, {responseType: 'text'});
  }
}
