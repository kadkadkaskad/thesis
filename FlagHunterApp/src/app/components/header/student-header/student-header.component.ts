import { Component, OnInit, Input } from '@angular/core';
import { User } from 'src/app/models/user';
import { AuthService } from 'src/app/services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-student-header',
  templateUrl: './student-header.component.html',
  styleUrls: ['./student-header.component.css']
})
export class StudentHeaderComponent implements OnInit {

  @Input() userName: string;

  constructor(private authService: AuthService, private router: Router) { }

  ngOnInit(): void {}

  onLogout() {
    this.authService.logout();
  }

}
