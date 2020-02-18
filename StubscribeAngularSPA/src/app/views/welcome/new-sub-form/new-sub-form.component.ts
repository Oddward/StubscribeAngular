import { SubServicesService } from './../../../sub-services.service';
import { Observable } from 'rxjs';
import { Component, OnInit, Inject } from '@angular/core';
// import { HttpClient } from '@angular/common/Http';
import {FormBuilder, FormControl, FormGroup} from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { DateAdapter, MAT_DATE_FORMATS, MAT_DATE_LOCALE } from '@angular/material/core';
import { WelcomeComponent } from '../welcome.component';

export interface DialogData {
  id: number;
  name: string;
  categoryId: number;
  logo_loc: any;
}

export const MY_FORMATS = {
  parse: {
    dateInput: ''
  }
}

@Component({
  selector: 'app-new-sub-form',
  templateUrl: './new-sub-form.component.html',
  // styleUrls: ['./new-sub-form.component.scss']
})
export class NewSubFormComponent implements OnInit {
  subs: any;
  startDate = new Date();

  constructor(
    public dialogRef: MatDialogRef<NewSubFormComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DialogData,
    public services: SubServicesService) { }

  ngOnInit() {
    this.getServices();
  }

  getServices() {
    // get values from api
    this.services.getServices().subscribe( (data) => {
      this.subs = data;
      console.log(this.subs);
    }, error =>
    console.log(error));
  }

  onCancel(): void {
    this.dialogRef.close();
  }

}
