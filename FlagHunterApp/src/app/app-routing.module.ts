import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './components/login/login.component';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { TestComponent } from './components/test/test.component';

const routes: Routes = [

  // {path : 'admin', component : AdminComponent, //canActivate:[AuthGuard],
  //   children : [
  //     {path : 'users', component : UserDetailListComponent},
  //     {path : 'paths', component : PathDetailListComponent},
  //     {path : 'challenges', component : ChallengeDetailListComponent},
  //   ]
  // },
  { path: '', redirectTo: '/login', pathMatch: 'full' },
  { path: 'login', component: LoginComponent, data: { animation: 'LoginPage' } },

  // {path : 'home', redirectTo : '/home/paths', pathMatch: 'full'},
  { path: 'dashboard', component: DashboardComponent }, //canActivate:[AuthGuard],
  //   children : [
  //     {path : 'paths', component : PathListComponent},
  //   ]
  // },
  {path : 'test/:testid', component : TestComponent} ,
  //   children : [
  //     {path : 'challenge/:challengeid', component: ChallengeComponent}
  //   ]
  // }
];

@NgModule({
  declarations: [],
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
