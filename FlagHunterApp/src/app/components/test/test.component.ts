import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { first, map } from 'rxjs/operators';
import { Test } from 'src/app/models/test';
import { User } from 'src/app/models/user';
import { AuthService } from 'src/app/services/auth.service';
import { TestService } from 'src/app/services/test.service';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {

  currentUser: User;
  loading = false;
  
  environmentId: string;

  testSolved: boolean = false;

  test: Test;
  testId: string;
  
  constructor(private testService: TestService, private authService: AuthService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.testId = this.route.snapshot.paramMap.get('testid');

    this.currentUser = this.authService.currentUserValue;
    this.loading = true;

    // Load test details
    this.testService.getTestById(this.testId).pipe(first()).subscribe(test => {
       this.loading = false;
       this.test = test;
    });

    // Get environmentid if test it's running
    this.testService.getEnvironment(this.testId).subscribe( id => {
      this.environmentId = id;
    });
  }

  accessEnvironment() {
    window.open('http://' + this.environmentId + '.traefik');
  }
  
  startEnvironment() {
    this.loading = true;
    this.testService.startTest(this.testId).pipe(first()).subscribe( envId => {
      this.loading = false;
      this.environmentId = envId;
    });
  }

  validateCTest() {
    this.loading = true;
    this.testService.validateCTest(this.testId).subscribe( res => {
      this.loading = false;
      this.testSolved = res;
      if(this.testSolved){
        this.environmentId = "";
      }
    });
  }

  stopEnvironment() {
    this.loading = true;
    this.testService.stopTest(this.environmentId).subscribe( stopped => {
      this.loading = false;
      if (stopped) {
        this.environmentId = null;
      }
    });
  }
}
