import { Component, OnInit, Input } from '@angular/core';
import { MembersService } from './../../members.service';
import { faEdit } from '@fortawesome/free-solid-svg-icons';
import { faShareAlt } from '@fortawesome/free-solid-svg-icons';
import { faCreditCard } from '@fortawesome/free-solid-svg-icons';
import { faCalendarTimes } from '@fortawesome/free-solid-svg-icons';
import { faUserCircle } from '@fortawesome/free-solid-svg-icons';

// export interface Sub {
//   id: 1;
//   name: string;
//   isActive: boolean;
//   datetime_created: any;
//   date_next_renewal: any;
//   price: 9.99;
//   plantypeId: string;
//   userId: 1;
//   members: any;
// }

@Component({
  selector: 'app-sub-button',
  templateUrl: './sub-button.component.html',
  styleUrls: ['./sub-button.component.scss']
})
export class SubButtonComponent implements OnInit {
  @Input() sub: any;
  members: any[]
  membersCount: number;
  customSubtitle: string;
  card: string;
  // date: Date = new Date;
  endDate: Date = new Date();
  date: number;
  status: true;

  // font awesome svg icons
  faEdit = faEdit;
  faShareAlt = faShareAlt;
  faUserCircle = faUserCircle;
  faCreditCard = faCreditCard;
  faCalendarTimes = faCalendarTimes;

  constructor( public membersService: MembersService ) {
    // this.sub.name = 'Spotify';
    // this.subStyle = this.sub.toLocaleLowerCase;
    this.customSubtitle = 'Me and the boys';
    this.card = '*420';
    this.date = 30 - this.endDate.getDate();
    this.membersCount = this.getMemberCount();
    // this.status = true;
   }

  ngOnInit() {
    this.getMemberCount();
  }

  getMemberCount() {
    this.membersService.getMembers(this.sub.id).subscribe((data) =>
    this.members = data, error =>
    console.log(error));

    return this.members.length;
  }

}
