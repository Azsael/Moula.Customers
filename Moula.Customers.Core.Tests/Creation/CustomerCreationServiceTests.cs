using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using Moula.Common.Validation;
using Moula.Common.Validation.Providers;
using Moula.Customers.Core.Creation;
using Moula.Customers.Core.Creation.Models;
using Moula.Customers.Entities.Context;
using Moula.Customers.Entities.Tests;
using Xunit;

namespace Moula.Customers.Core.Tests
{
	public class CustomerCreationServiceTests
	{
		private readonly CustomerCreationService _service;

	    private readonly Mock<IValidationProvider> _validationProvider;
	    private readonly ICustomerContext _context;

	    public CustomerCreationServiceTests()
	    {
		    _context = TestEntityFactory.SetupContext();
		    var entityFactory = TestEntityFactory.SetupEntityFactory(_context);

		    _validationProvider = new Mock<IValidationProvider>();

		    _service = new CustomerCreationService(entityFactory, _validationProvider.Object);
	    }


	    [Fact]
	    public async Task GivenCreateCustomer_WhenValidationFails_ThenValidationExceptionThrown()
	    {
		    _validationProvider.Setup(x => x.Validate(It.IsAny<NewCustomer>()))
			    .Returns(new ValidationSummary { Errors = new [] {new ValidationError() }});

		    var response = await _service.CreateCustomer(new NewCustomer());

		    response.IsSuccessful.Should().BeFalse();
	    }

	    [Fact]
	    public async Task GivenCreateCustomer_WhenValidationPasses_ThenCustomerCreated()
	    {
		    _validationProvider.Setup(x => x.Validate(It.IsAny<NewCustomer>()))
			    .Returns(new ValidationSummary());

		    var newCustomer = new NewCustomer
			{
				FirstName = "Ted",
				LastName = "Bob",
				Email = "ted@bob.com"
		    };

		    var response = await _service.CreateCustomer(newCustomer);

		    response.IsSuccessful.Should().BeTrue();

		    _context.Customers
			    .Any(x => x.FirstName == "Ted" && x.LastName == "Bob" && x.Email == "ted@bob.com").Should().BeTrue();
	    }
	}
}
