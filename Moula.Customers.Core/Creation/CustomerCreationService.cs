using System;
using System.Threading.Tasks;
using Moula.Common;
using Moula.Common.Foundation.Responses;
using Moula.Common.Validation.Providers;
using Moula.Customers.Core.Creation.Models;
using Moula.Customers.Entities;
using Moula.Customers.Entities.Context;
using Moula.Customers.Entities.Models;

namespace Moula.Customers.Core.Creation
{
	internal class CustomerCreationService : ICustomerCreationService
	{
		private readonly IFactory<ICustomerContext> _entityFactory;
		private readonly IValidationProvider _validationProvider;

		public CustomerCreationService(IFactory<ICustomerContext> entityFactory, IValidationProvider validationProvider)
		{
			_entityFactory = entityFactory;
			_validationProvider = validationProvider;
		}

		public async Task<IResponse> CreateCustomer(NewCustomer newCustomer)
		{
			var response = _validationProvider.Validate(newCustomer);

			if (response.IsInvalid)
				return response.ToResponse();

			var dbContext = _entityFactory.Create();

			var customer = new Customer
			{
				FirstName = newCustomer.FirstName,
				LastName = newCustomer.LastName,
				Email = newCustomer.Email,
				DateOfBirth = newCustomer.DateOfBirth
			};

			dbContext.Customers.Add(customer);

			await dbContext.SaveChangesAsync();

			return ResponseType.Success;
		}

	}
}