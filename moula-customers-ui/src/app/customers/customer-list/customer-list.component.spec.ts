import { Observable, of } from 'rxjs';
import { NO_ERRORS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { MatTableModule } from '@angular/material';
import { CustomerListComponent } from './customer-list.component';
import { AppTestModule } from '../../../tests/test.module';
import { Router } from '@angular/router';
import { CustomerService } from '../customer.service';

const router = jasmine.createSpyObj('Router', ['navigate']);
const cs = jasmine.createSpyObj('CustomerService', ['getOldCustomers']);

cs.getOldCustomers.and.returnValue(of([]));

describe('CustomerListComponent', () => {
  let component: CustomerListComponent;
  let fixture: ComponentFixture<CustomerListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      schemas: [NO_ERRORS_SCHEMA],
      declarations: [CustomerListComponent],
      imports: [
        AppTestModule,
        MatTableModule
      ],
      providers: [
        { provide: Router, useValue: router },
        { provide: CustomerService, useValue: cs }
      ],
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CustomerListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
