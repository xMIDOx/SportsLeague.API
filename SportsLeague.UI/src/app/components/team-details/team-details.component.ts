import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';
import { TeamDetails } from 'src/app/models/team-details.model';
import { LeagueService } from 'src/app/services/league.service';

@Component({
  selector: 'app-team-details',
  templateUrl: './team-details.component.html',
  styleUrls: ['./team-details.component.css']
})
export class TeamDetailsComponent implements OnInit {
  teamId = 0;
  teamDetails$ = new Observable<TeamDetails>();

  constructor(private leagueService: LeagueService, private route: ActivatedRoute) {
    this.teamId = this.route.snapshot.params['id'];    
  }

  ngOnInit(): void {
    this.teamDetails$ = this.leagueService.getTeamDetails(this.teamId);
    this.teamDetails$.subscribe(res => console.log(res));    
  }

}
