using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moula.Common;
using Moula.Customers.Core.List.Models;
using Moula.Customers.Entities;
using Moula.Customers.Entities.Context;

namespace Moula.Customers.Core.List
{
	internal class CustomerListService : ICustomerListService
	{
		private readonly IFactory<ICustomerContext> _entityFactory;

		public CustomerListService(IFactory<ICustomerContext> entityFactory)
		{
			_entityFactory = entityFactory;
		}

		/// <summary>
		/// This gets oldest 5 customers and then returns them ordered by lastname
		/// this is a very quirky requirement
		/// that I would try to look at better to understand clients needs.
		///
		/// Assuming Oldest customers means by age and not creation.
		/// </summary>
		public async Task<IList<CustomerVM>> GetOldCustomers()
		{
			var dbContext = _entityFactory.Create();

			var customers = await dbContext.Customers
				.OrderBy(x => x.DateOfBirth)
				.Take(5)
				.ToListAsync();

			return customers.Select(x => new CustomerVM
				{
					CustomerId = x.Id,
					CustomerCode = x.Code,
					FirstName = x.FirstName,
					LastName = x.LastName,
					FullName = x.FullName,
					Email = x.Email,
					DateOfBirth = x.DateOfBirth
				}).OrderBy(x => x.LastName)
				.ToList();
		}
	}
}