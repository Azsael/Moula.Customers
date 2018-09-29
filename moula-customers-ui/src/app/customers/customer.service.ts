import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

export class NewCustomer {
  firstName: string;
  lastName: string;
  email: string;
  dateOfBirth?: Date;
}

export class Customer {
  customerId: number;
  customerCode: string;

  firstName: string;
  lastName: string;
  email: string;
  dateOfBirth?: Date;
}

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor(private _http: HttpClient) { }

  public createCustomer(newCustomer: NewCustomer): Observable<void> {
    return this._http.post<void>('/api/v1/customers', newCustomer);
  }

  public getOldCustomers(): Observable<Customer[]> {
    return this._http.get<Customer[]>('/api/v1/customers');
  }
}
