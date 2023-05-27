import { Component, Input, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { take } from 'rxjs';
import { TeamMember } from 'src/app/models/team-member.model';
import { LeagueService } from 'src/app/services/league.service';

@Component({
  selector: 'app-team-members-list',
  templateUrl: './team-members-list.component.html',
  styleUrls: ['./team-members-list.component.css']
})
export class TeamMembersListComponent implements OnInit {
  @Input() teamId: number;
  @Input() teamMembers: TeamMember[];  
  public teamMember = <TeamMember>{};

 constructor(private leagueService: LeagueService) { }

  ngOnInit(): void { }

 onSubmit(memberForm: NgForm) {    
  this.teamMember.teamId = this.teamId;

  this.leagueService
  .addNewTeamMember(this.teamMember)
  .pipe(take(1))
  .subscribe(newMember => this.teamMembers.push(newMember));

  memberForm.reset();
 }
}
