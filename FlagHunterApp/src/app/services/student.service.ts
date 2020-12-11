import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { map } from 'rxjs/operators';
import { Course } from '../models/course';
import { Test } from '../models/test';
import { env } from 'process';
import { StudentTest } from '../models/studentTest';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor(private http: HttpClient) { }

  getCurrentStudentTests() {
    return this.http.get<Test[]>(`${environment.apiUrl}/Student/Tests`);
  }
}
