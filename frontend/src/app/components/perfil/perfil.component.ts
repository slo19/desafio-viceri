import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router'
import { HeroiService } from '../../services/heroi.service';
import { HeroiDTO } from '../../models/Heroi';

@Component({
  selector: 'app-perfil',
  templateUrl: './perfil.component.html',
  styleUrls: ['./perfil.component.scss']
})
export class PerfilComponent implements OnInit {
  id: number;
  public heroi: HeroiDTO;
  constructor(private route: ActivatedRoute,
              private heroiService: HeroiService,
              private router: Router) { }

  ngOnInit(): void {
    this.id = Number(this.route.snapshot.paramMap.get("id"));
    this.getHeroi(this.id);
  }

  getHeroi(id: number) {
    this.heroiService.get(id).subscribe((res) => this.heroi = res);
  }

  excluir() {
    this.heroiService.delete(this.id).subscribe((res) => this.router.navigate([""]));
  }

}
