import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NewSubButtonComponent } from './new-sub-button.component';

describe('NewSubButtonComponent', () => {
  let component: NewSubButtonComponent;
  let fixture: ComponentFixture<NewSubButtonComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NewSubButtonComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NewSubButtonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
