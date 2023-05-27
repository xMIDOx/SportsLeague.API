import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, map } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { Team } from '../models/team.model';
import { TeamDetails } from '../models/team-details.model';
import { TeamMember } from '../models/team-member.model';
import { Schedule } from '../models/schedule.model';

@Injectable({
  providedIn: 'root'
})
export class LeagueService {
  private baseAddress: string = environment.urlAddress;

  constructor(private http: HttpClient) { }

  public getTeamsList(): Observable<Team[]> {
    return this.http.get(this.baseAddress + 'api/Team').pipe(
      map(res => res as Team[])
    );
  }

  public getTeamDetails(id: number): Observable<TeamDetails> {
    return this.http.get(this.baseAddress + 'api/team/' + id).pipe(
      map(res => res as TeamDetails)
    );
  }

  public CreateNewTeam(team: Team): Observable<Team> {
    return this.http.post(this.baseAddress + 'api/team', team).pipe(
      map(res => res as Team)
    );
  }

  public addNewTeamMember(member: TeamMember): Observable<TeamMember> {
    return this.http.post(this.baseAddress + 'api/TeamMember', member).pipe(
      map(res => res as TeamMember)
    );
  }

  public addNewSchedule(schedule: Schedule): Observable<Schedule> {
    return this.http.post(this.baseAddress + 'api/Schedule', schedule).pipe(
      map(res => res as Schedule)
    );
  }

  public DeleteTeam(id: number): Observable<object> {
    return this.http.delete(this.baseAddress + 'api/Team?id=' + id);
  }
  
}
