import { Superpoder } from './Superpoder';


export interface Heroi {
  id?: number,
  nome: string,
  nomeHeroi: string,
  dataNascimento?: Date,
  altura: number,
  peso:number,
}

export interface HeroiDTO {
  heroi: Heroi,
  superpoderes: Superpoder[]
}

export interface CadastroHeroiDTO {
  heroi: Heroi,
  superpoderesIds: number[]
}
