import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit {
  public newArrivalsList: any[] = [];


  constructor() {
    this.newArrivalsList.push({ name: 'NEW ARRIVALS' });
    this.newArrivalsList.push({ name: 'Adam' });
    this.newArrivalsList.push({ name: 'Armud' });
    this.newArrivalsList.push({ name: 'qaqa' });
  }

  ngOnInit(): void {}
}
