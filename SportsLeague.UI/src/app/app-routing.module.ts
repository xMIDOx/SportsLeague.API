import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TeamFormComponent } from './components/team-form/team-form.component';
import { TeamsListComponent } from './components/teams-list/teams-list.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { TeamDetailsComponent } from './components/team-details/team-details.component';
import { ScheduleFormComponent } from './components/schedule-form/schedule-form.component';
import { HomeComponent } from './components/home/home.component';

const routes: Routes = [
{ path:'home', component: HomeComponent },
{ path:'new-team', component: TeamFormComponent },
{ path:'teams', component: TeamsListComponent },
{ path:'schedule', component: ScheduleFormComponent },
{ path:'team-details/:id', component: TeamDetailsComponent },
{ path: '404', component: NotFoundComponent }, 
{ path: '', redirectTo: '/home', pathMatch: 'full' },
{ path: '**', redirectTo: '/404', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
