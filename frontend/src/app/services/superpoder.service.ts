import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Superpoder} from '../models/Superpoder';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SuperpoderService {
  private apiUrl = 'http://localhost:5219/api';
  private headers = new HttpHeaders()
    .set('content-type', 'application/json')
    .set('Access-Control-Allow-Origin', 'http://localhost:5219');

  constructor(private http: HttpClient) { }


  get(token: string): Observable<Superpoder[]> {
    return this.http.get<Superpoder[]>(this.apiUrl + '/superpoder?token=' + token, {'headers': this.headers});
  }
  create(body: Superpoder): Observable<Superpoder> {
    return this.http.post<Superpoder>(this.apiUrl + '/superpoder', body, {'headers': this.headers })
  }

}
