import { Component, OnInit } from '@angular/core';
import { FormControl, Validators, FormGroup, FormBuilder } from '@angular/forms';
import { HeroiService } from '../../services/heroi.service';
import { Heroi,CadastroHeroiDTO } from '../../models/Heroi';
import { Superpoder } from '../../models/Superpoder';
import { SuperpoderService } from '../../services/superpoder.service';

@Component({
  selector: 'app-criacao-heroi',
  templateUrl: './criacao-heroi.component.html',
  styleUrls: ['./criacao-heroi.component.scss']
})
export class CriacaoHeroiComponent implements OnInit {
  public form: FormGroup;
  public submitted = false;
  public superpoderes: Superpoder[];

  constructor(private heroiService: HeroiService,
              private formBuilder: FormBuilder,
              private superpoderService: SuperpoderService) { }

  ngOnInit(): void {
    this.form = this.formBuilder.group({
      nome: ['', Validators.required],
      nomeHeroi: ['', Validators.required],
      dataNascimento: [''],
      altura: [0.0, Validators.required],
      peso: [0.0, Validators.required],
    });
  }

  public submitForm() {
    this.submitted = true;
  }

  public getSuperpoderes(token: string) {
    if (token.length > 2){
    this.superpoderService.get(token).subscribe(res => this.superpoderes = res);
    }
  }

}
