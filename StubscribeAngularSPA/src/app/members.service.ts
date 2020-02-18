import { HttpClient, HttpHeaders } from '@angular/common/Http';
import { Injectable } from '@angular/core';
import { identifierModuleUrl } from '@angular/compiler';

const httpOptions = {
  headers: new HttpHeaders(
    { 'Content-Type': 'application/json'}
  )
};

@Injectable({
  providedIn: 'root'
})
export class MembersService {
  membersUrl = 'http://localhost:5000/api/Members/';

  constructor(private http: HttpClient) { }

  getMembers(subId: number) {
    const url: string = this.membersUrl + subId;

    return this.http.get(url);
  }

  // GetMemberCount(id: number) {
  //   const url: string = this.membersUrl +  id;
  //   let members = this.http.get(url);

  //   return this.http.get(url);
  // }
}
