import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Heroi, HeroiDTO } from '../models/Heroi';
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

  get(id: number): Observable<HeroiDTO> {
    return this.http.get<HeroiDTO>(this.apiUrl + '/heroi/' + id, {'headers': this.headers});
  }
  create(body: Heroi): Observable<Heroi> {
    return this.http.post<Heroi>(this.apiUrl + '/heroi', body)
  }

  delete(id:number): Observable<any> {
      return this.http.delete<any>(this.apiUrl + '/heroi/' + id, {'headers': this.headers});
  }
}
