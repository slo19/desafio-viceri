import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { HeroiService } from '../../services/heroi.service';
import { Heroi } from '../../models/Heroi';

@Component({
  selector: 'app-lista',
  templateUrl: './lista.component.html',
  styleUrls: ['./lista.component.scss']
})
export class ListaComponent implements OnInit {
  public herois: Heroi[] = [];

  constructor(private heroiService: HeroiService) { }

  ngOnInit(): void {
    this.getHerois();
  }

  getHerois(): void {
    this.heroiService.getAll().subscribe((res) => this.herois = res);
  }
}
