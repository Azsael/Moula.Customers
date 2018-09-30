using System;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Moula.Customers.Core.List;
using Moula.Customers.Entities.Tests;
using Xunit;

namespace Moula.Customers.Core.Tests
{
    public class CustomerListServiceTests
	{
		private readonly CustomerListService _service;

		public CustomerListServiceTests()
		{
			var context = TestEntityFactory.SetupContext();
			var entityFactory = TestEntityFactory.SetupEntityFactory(context);

			_service = new CustomerListService(entityFactory);
		}

		[Fact]
        public async Task GivenGetOldCustomers_WhenRetrievingCustomers_OnlyOldestFiveReturned()
		{
			var customers = await _service.GetOldCustomers();

			customers.Should().HaveCountLessOrEqualTo(5);

			customers.First().CustomerId.Should().Be(1000);
			customers.Last().CustomerId.Should().Be(6000);
		}
    }
}
