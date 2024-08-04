import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Heroi } from '../models/Heroi';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class HeroiService {
  private apiUrl = 'http://localhost:5219/api';
  private headers = new HttpHeaders()
    .set('content-type', 'application/json')
    .set('Access-Control-Allow-Origin', 'http://localhost:5219');

  constructor(private http: HttpClient) { }

  getAll(): Observable<Heroi[]> {
    return this.http.get<Heroi[]>(this.apiUrl + '/heroi', {'headers': this.headers});
  }
}
