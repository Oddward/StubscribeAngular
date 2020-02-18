import { HttpClient, HttpHeaders } from '@angular/common/Http';
import { Injectable } from '@angular/core';

const httpOptions = {
  headers: new HttpHeaders(
    { 'Content-Type': 'application/json'}
  )
};

@Injectable({
  providedIn: 'root'
})
export class SubServicesService {
  servicesUrl = 'http://localhost:5000/api/SubServices';

  constructor( private http: HttpClient) { }

  getServices() {
    return this.http.get(this.servicesUrl);
  }
}
