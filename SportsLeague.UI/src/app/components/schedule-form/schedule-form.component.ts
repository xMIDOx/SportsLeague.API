import { Component, OnInit } from '@angular/core';
import { NgControl, NgForm, NgModel } from '@angular/forms';
import { Observable, take } from 'rxjs';
import { Schedule } from 'src/app/models/schedule.model';
import { Team } from 'src/app/models/team.model';
import { LeagueService } from 'src/app/services/league.service';

@Component({
  selector: 'app-schedule-form',
  templateUrl: './schedule-form.component.html',
  styleUrls: ['./schedule-form.component.css']
})
export class ScheduleFormComponent implements OnInit {
  teams$ = new Observable<Team[]>();  
  schedule = <Schedule>{};

  constructor (private leagueService: LeagueService) { }

  ngOnInit(): void {
    this.teams$ = this.leagueService.getTeamsList()    
  }

  checkId(control: NgModel) {
    if (this.schedule.awayTeamId == this.schedule.homeTeamId)
      control.control.setErrors({dublicate: true});
    else
      control.control.setErrors(null);
  }

  public onSubmit(scheduleForm: NgForm) {    

    this.leagueService.addNewSchedule(this.schedule)
    .pipe(take(1))
    .subscribe(res => console.log(res));
  }
}
