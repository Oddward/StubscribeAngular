import { MembersService } from './../../members.service';
import { HttpClient } from '@angular/common/Http';
import { NewSubFormComponent } from './new-sub-form/new-sub-form.component';
import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { SubscriptionsService } from 'src/app/subscriptions.service';

export interface Services {
  id: number;
  name: string;
}

@Component({
  selector: 'app-welcome',
  templateUrl: './welcome.component.html',
  styleUrls: ['./welcome.component.scss']
})
export class WelcomeComponent implements OnInit {
  today: Date = new Date();
  todayStr: string;
  user: any = {
    name: 'Mugtaba',
    card: '*550'
  };
  subs: any = [
    { id: 1, name: 'Spotify' },
    { id: 2, name: 'Netflix' },
    { id: 3, name: 'Youtube Premium' }
  ];
  services: any;

  constructor(
    private dialog: MatDialog,
    private http: HttpClient,
    public subscriptions: SubscriptionsService,
    public members: MembersService ) {
    this.todayStr = this.today.toLocaleDateString();
  }

  ngOnInit() {
    this.getSubs();
  }

  onAdd(): void {
    const dialogRef = this.dialog.open(NewSubFormComponent, {
      width: '350px',
      // data: this.services.name,
      data: this.services,
    });

    dialogRef.afterClosed().subscribe( result =>
      this.http.post('http://localhost:5000/api/Subcriptions', result));
  }

  getSubs() {
    this.http.get('http://localhost:5000/api/subscriptions').subscribe((result: any) => {
      this.subs = result; },
      error => console.log(error));

    this.http.get('http://localhost:5000/api/subservices').subscribe((result: any) => {
      this.services = result; },
      error => console.log(error));
  }

  getMembers( subId: any ) {
    this.members.getMembers(subId);
  }
}
