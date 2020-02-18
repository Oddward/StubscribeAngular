import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/Http';

@Component({
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.scss']
})
export class ValueComponent implements OnInit {
  values: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getValues();
  }

  getValues() {
    this.http.get('http://localhost:5000/weatherforecast').subscribe(response => {
      this.values = response;
    }, error => {
      console.log(error);
    });
  }

}
// export interface Weather {
//   date: Date;
//   temperatureC: number;
//   temperatureF: number;
//   summary: string;
// }
