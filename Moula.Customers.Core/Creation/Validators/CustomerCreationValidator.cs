using System;
using System.Collections.Generic;
using Moula.Common.Extensions;
using Moula.Common.Validation;
using Moula.Common.Validation.Providers;
using Moula.Customers.Core.Creation.Models;

namespace Moula.Customers.Core.Creation.Validators
{
    internal class CustomerCreationValidator : IValidator<NewCustomer>
    {
	    public IEnumerable<ValidationError> Validate(NewCustomer newCustomer)
	    {
			if (newCustomer.FirstName.IsNullOrWhiteSpace())
				yield return new ValidationError("FirstName", "First Name is required.");

			if (newCustomer.LastName.IsNullOrWhiteSpace())
				yield return new ValidationError("LastName", "Last Name is required.");

			if (newCustomer.Email.IsNullOrWhiteSpace())
				yield return new ValidationError("Email", "Email is required.");
			else if (!EmailValidator.IsValidEmail(newCustomer.Email))
				yield return new ValidationError("Email", "Email is invalid.");
		}
    }
}
