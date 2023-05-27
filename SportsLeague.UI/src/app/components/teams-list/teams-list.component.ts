import { Component, OnInit } from '@angular/core';
import { Observable, take } from 'rxjs';
import { Team } from 'src/app/models/team.model';
import { LeagueService } from 'src/app/services/league.service';

@Component({
  selector: 'app-teams-list',
  templateUrl: './teams-list.component.html',
  styleUrls: ['./teams-list.component.css']
})
export class TeamsListComponent implements OnInit {
teamList$ = new Observable<Team[]>();
isAvailable = true;

constructor(private leagueService: LeagueService) { }

  ngOnInit(): void {
    this.teamList$ = this.leagueService.getTeamsList();
  }

  delete(id: number) {
    if(confirm("Are you sure ?")){
      this.isAvailable = false;
      this.leagueService.DeleteTeam(id).pipe(take(1)).subscribe(res => {
      this.isAvailable = true;
      });
    }    
  }
}
