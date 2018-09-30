using System;
using Microsoft.EntityFrameworkCore;
using Moq;
using Moula.Common;
using Moula.Customers.Entities.Context;
using Moula.Customers.Entities.Tests.SampleData;
using Xunit;

namespace Moula.Customers.Entities.Tests
{
	public static class TestEntityFactory
	{
		public static IFactory<T> SetupEntityFactory<T>(T context)
		{
			var entityFactory = new Mock<IFactory<T>>();
			entityFactory.Setup(x => x.Create()).Returns(context);

			return entityFactory.Object;
		}

		public static ICustomerContext SetupContext(bool seedContext = true)
		{
			var options = new DbContextOptionsBuilder<CustomerContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
			var dbContext = new CustomerContext(options);

			if (seedContext)
				SeedContext(dbContext);

			return dbContext;
		}

		private static void SeedContext(CustomerContext dbContext)
		{
			dbContext.Customers.AddRange(SampleCustomerData.GetCustomers());
			dbContext.SaveChanges();
		}
	}
}
