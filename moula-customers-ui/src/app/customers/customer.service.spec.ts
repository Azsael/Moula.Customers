import { TestBed } from '@angular/core/testing';
import { HttpClient } from '@angular/common/http';

import { CustomerService } from './customer.service';

const httpClient = jasmine.createSpyObj('HttpClient', ['post', 'get']);

describe('CustomerService', () => {
  beforeEach(() => TestBed.configureTestingModule({
    providers: [
      { provide: HttpClient, useValue: httpClient },
    ]
  }));

  it('should be created', () => {
    const service: CustomerService = TestBed.get(CustomerService);
    expect(service).toBeTruthy();
  });
});
