import { Component, OnInit, ElementRef, ViewChild } from '@angular/core';
import { StudentService } from 'src/app/services/student.service';
import { first } from 'rxjs/operators';
import { AuthService } from 'src/app/services/auth.service';
import { User } from 'src/app/models/user';
import { Test } from 'src/app/models/test';
import { Router } from '@angular/router';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  container: any;
  currentUser: User;
  loading = false;
  tests: Test[] = [];

  constructor(private studentService: StudentService, private authService: AuthService, private router: Router) { }

  ngOnInit(): void {

    this.currentUser = this.authService.currentUserValue;
    this.loading = true;
    this.studentService.getCurrentStudentTests().pipe(first()).subscribe(tests => {
      this.loading = false;
      this.tests = tests;
      // tests.forEach(t => {
      //   t.startTime = moment(t.startTime).format('YYYY-MM-DD');
      // });
    })
  }

  testDetails(id): void {
    this.router.navigate(['/test', id]);
  }
  

  selectTest(id: string){
    console.log(id);
  }

}
