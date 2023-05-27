import { Component, Input, OnInit } from '@angular/core';
import { Schedule } from 'src/app/models/schedule.model';

@Component({
  selector: 'app-schedule-list',
  templateUrl: './schedule-list.component.html',
  styleUrls: ['./schedule-list.component.css']
})
export class ScheduleListComponent implements OnInit {
  @Input() homeSchedules: Schedule[];
  @Input() awaySchedules: Schedule[];

  constructor() {}

  ngOnInit(): void { }
}
