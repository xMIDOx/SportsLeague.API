import { Schedule } from "./schedule.model";
import { TeamMember } from "./team-member.model"

export interface TeamDetails {
    id: number
    name: string,
    city: string,
    coach: string,
    
    teamMembers: TeamMember[];
    homeSchedules: Schedule[];
    awaySchedules: Schedule[];
}