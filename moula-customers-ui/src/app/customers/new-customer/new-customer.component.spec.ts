import { NO_ERRORS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { MatFormFieldModule, MatInputModule } from '@angular/material';
import { NewCustomerComponent } from './new-customer.component';
import { AppTestModule } from '../../../tests/test.module';
import { Router } from '@angular/router';
import { CustomerService } from '../customer.service';

const router = jasmine.createSpyObj('Router', ['navigate']);
const cs = jasmine.createSpyObj('CustomerService', ['createCustomer']);

describe('NewCustomerComponent', () => {
  let component: NewCustomerComponent;
  let fixture: ComponentFixture<NewCustomerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      schemas: [NO_ERRORS_SCHEMA],
      imports: [
        AppTestModule,
        MatFormFieldModule,
        MatInputModule,
      ],
      providers: [
        { provide: Router, useValue: router },
        { provide: CustomerService, useValue: cs }
      ],
      declarations: [NewCustomerComponent]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NewCustomerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
