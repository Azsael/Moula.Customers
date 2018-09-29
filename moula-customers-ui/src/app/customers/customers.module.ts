import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule, MatDatepickerModule, MatFormFieldModule, MatInputModule, MatTableModule } from '@angular/material';
import { CustomerListComponent } from './customer-list/customer-list.component';
import { CustomersRoutingModule } from './customers-routing.module';
import { NewCustomerComponent } from './new-customer/new-customer.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  imports: [
    CommonModule,
    HttpClientModule,
    ReactiveFormsModule,
    CustomersRoutingModule,
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    MatDatepickerModule,
    MatTableModule
  ],
  declarations: [CustomerListComponent, NewCustomerComponent]
})
export class CustomersModule { }
