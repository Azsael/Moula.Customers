import { Component, OnInit } from '@angular/core';
import { CustomerService, Customer } from '../customer.service';

@Component({
  selector: 'mou-customer-list',
  templateUrl: './customer-list.component.html',
  styleUrls: ['./customer-list.component.scss']
})
export class CustomerListComponent implements OnInit {
  public displayedColumns = ['fullName', 'email', 'dateOfBirth', 'customerCode'];
  public customers: Customer[];

  constructor(private _cs: CustomerService) { }

  async ngOnInit() {
    this.customers = await this._cs.getOldCustomers().toPromise();
  }

}
