using System.Linq;
using FluentAssertions;
using Moula.Customers.Core.Creation.Models;
using Moula.Customers.Core.Creation.Validators;
using Xunit;

namespace Moula.Customers.Core.Tests
{
    public class CustomerCreationValidatorTests
	{
		private readonly CustomerCreationValidator _validator;

		public CustomerCreationValidatorTests()
		{
			_validator = new CustomerCreationValidator();
		}
		
		[Fact]
		public void GivenValidate_WhenFirstNameNotProvided_ThenFirstNameRequiredError()
		{
			var newCustomer = new NewCustomer
			{
				LastName = "Rawr",
				Email = "Test@test.com"
			};

			var results = _validator.Validate(newCustomer).ToList();

			results.Should().HaveCount(1);
			results.Should().Contain(x => x.FieldName == "FirstName" && x.ErrorMessage == "First Name is required.");
		}

		[Fact]
		public void GivenValidate_WhenLastNameNotProvided_ThenLastNameRequiredError()
		{
			var newCustomer = new NewCustomer
			{
				FirstName = "Rawr",
				Email = "Test@test.com"
			};

			var results = _validator.Validate(newCustomer).ToList();

			results.Should().HaveCount(1);
			results.Should().Contain(x => x.FieldName == "LastName" && x.ErrorMessage == "Last Name is required.");
		}

		[Fact]
		public void GivenValidate_WhenEmailNotProvided_ThenEmailRequiredError()
		{
			var newCustomer = new NewCustomer
			{
				FirstName = "Rawr",
				LastName = "Rawr"
			};

			var results = _validator.Validate(newCustomer).ToList();

			results.Should().HaveCount(1);
			results.Should().Contain(x => x.FieldName == "Email" && x.ErrorMessage == "Email is required.");
		}

		[Fact]
		public void GivenValidate_WhenEmailIsInvalid_ThenEmailInvalidError()
		{
			var newCustomer = new NewCustomer
			{
				FirstName = "Rawr",
				LastName = "Rawr",
				Email = "test@"
			};

			var results = _validator.Validate(newCustomer).ToList();

			results.Should().HaveCount(1);
			results.Should().Contain(x => x.FieldName == "Email" && x.ErrorMessage == "Email is invalid.");
		}

		[Fact]
		public void GivenValidate_WhenValidData_ThenNoErrors()
		{
			var newCustomer = new NewCustomer
			{
				FirstName = "Rawr",
				LastName = "Rawr",
				Email = "Test@test.com"
			};

			var results = _validator.Validate(newCustomer).ToList();

			results.Should().HaveCount(0);
		}
	}
}
