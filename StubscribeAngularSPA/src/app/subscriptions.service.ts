import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/Http';

const httpOptions = {
  headers: new HttpHeaders(
    { 'Content-Type': 'application/json'}
  )
};

@Injectable({
  providedIn: 'root'
})
export class SubscriptionsService {
  subscriptionsUrl = 'http://localhost:5000/api/subscriptions';

  constructor( private http: HttpClient) { }

  getSubscriptions() {
    return this.http.get(this.subscriptionsUrl);
  }
}
