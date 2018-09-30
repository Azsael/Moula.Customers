import { CustomerService, NewCustomer } from './../customer.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'mou-new-customer',
  templateUrl: './new-customer.component.html',
  styleUrls: ['./new-customer.component.scss']
})
export class NewCustomerComponent implements OnInit {
  public isSubmitting: boolean;
  public form: FormGroup;
  public error: string;

  constructor(private _fb: FormBuilder, private _cs: CustomerService, private _router: Router) { }

  ngOnInit() {
    this.form = this._fb.group({
      firstName: [null, [Validators.required]],
      lastName: [null, [Validators.required]],
      email: [null, [Validators.required, Validators.email]],
      dateOfBirth: null
    });
  }

  hasError(control: string, error: string): boolean {
    return this.form.controls[control].hasError(error);
  }

  async onSubmit(model: NewCustomer, isValid: boolean) {
    if (!isValid) { return; }

    this.isSubmitting = true;
    try {
      await this._cs.createCustomer(model).toPromise();

      this._router.navigate(['..']);
    } catch (error) {
      this.error = handleServerValidation(error, this.form);
    } finally {
      this.isSubmitting = false;
    }
  }
}

export const StandardErrorMessage = 'An error occurred, please try again.';

export function handleServerValidation(error: HttpErrorResponse, form?: FormGroup): string {
  if (!error || !error.error) { return StandardErrorMessage; }

  if (error.error.errors && form) {
    // todo: apply field errors to form
  }

  return error.error.message || StandardErrorMessage;
}
