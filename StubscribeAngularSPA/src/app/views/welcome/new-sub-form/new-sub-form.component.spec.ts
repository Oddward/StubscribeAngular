import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NewSubFormComponent } from './new-sub-form.component';

describe('NewSubFormComponent', () => {
  let component: NewSubFormComponent;
  let fixture: ComponentFixture<NewSubFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NewSubFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NewSubFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
