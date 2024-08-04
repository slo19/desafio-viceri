import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { ListaComponent } from '../app/components/lista/lista.component';
import { PerfilComponent } from '../app/components/perfil/perfil.component';
import { CriacaoHeroiComponent } from '../app/components/criacao-heroi/criacao-heroi.component';

const routes: Routes = [
  {path: '', component: ListaComponent},
  {path: 'criacao', component: CriacaoHeroiComponent},
  {path: 'perfil', component: PerfilComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
