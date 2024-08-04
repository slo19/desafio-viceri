import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CriacaoHeroiComponent } from './criacao-heroi.component';

describe('CriacaoHeroiComponent', () => {
  let component: CriacaoHeroiComponent;
  let fixture: ComponentFixture<CriacaoHeroiComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CriacaoHeroiComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CriacaoHeroiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
