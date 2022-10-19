import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SuggestedbooksComponent } from './suggestedbooks.component';

describe('SuggestedbooksComponent', () => {
  let component: SuggestedbooksComponent;
  let fixture: ComponentFixture<SuggestedbooksComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SuggestedbooksComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SuggestedbooksComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
