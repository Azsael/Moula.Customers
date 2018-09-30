import { CommonModule } from '@angular/common';
import { NgModule, NO_ERRORS_SCHEMA } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';
export { NO_ERRORS_SCHEMA } from '@angular/core';

@NgModule({
  exports: [
    CommonModule,
    NoopAnimationsModule
  ],
  imports: [
    CommonModule,
    NoopAnimationsModule
  ],
  providers: [
    FormBuilder
  ],
  schemas: [NO_ERRORS_SCHEMA],
})
export class AppTestModule { }
