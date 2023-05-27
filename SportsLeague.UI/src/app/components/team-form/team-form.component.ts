import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Team } from 'src/app/models/team.model';
import { LeagueService } from 'src/app/services/league.service';

@Component({
  selector: 'app-team-form',
  templateUrl: './team-form.component.html',
  styleUrls: ['./team-form.component.css']
})
export class TeamFormComponent {
  team = <Team>{};

  constructor(private leagueService: LeagueService) {}

  public onSubmit(teamForm: NgForm) {
    console.log(teamForm);
    console.log(this.team);

    this.leagueService
    .CreateNewTeam(this.team)
    .subscribe(newteam => this.team = newteam);
  }
}
