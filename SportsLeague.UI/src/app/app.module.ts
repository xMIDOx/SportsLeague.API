import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { TeamFormComponent } from './components/team-form/team-form.component';
import { TeamsListComponent } from './components/teams-list/teams-list.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { TeamDetailsComponent } from './components/team-details/team-details.component';
import { ScheduleListComponent } from './components/schedule-list/schedule-list.component';
import { TeamMembersListComponent } from './components/team-members-list/team-members-list.component';
import { ScheduleFormComponent } from './components/schedule-form/schedule-form.component';
import { HomeComponent } from './components/home/home.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    TeamFormComponent,
    TeamsListComponent,
    NotFoundComponent,
    TeamDetailsComponent,
    ScheduleListComponent,
    TeamMembersListComponent,
    ScheduleFormComponent,
    HomeComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
