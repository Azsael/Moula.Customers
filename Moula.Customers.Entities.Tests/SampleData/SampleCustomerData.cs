using System;
using System.Collections.Generic;
using System.Text;
using Moula.Customers.Entities.Models;

namespace Moula.Customers.Entities.Tests.SampleData
{
	public static class SampleCustomerData
	{
		public static IEnumerable<Customer> GetCustomers()
		{
			yield return new Customer
			{
				Id = 1000,
				FirstName = "f1",
				LastName = "l1",
				Email = "1@test.com",
				DateOfBirth = new DateTime(1955, 10, 10)
			};
			yield return new Customer
			{
				Id = 2000,
				FirstName = "f2",
				LastName = "l2",
				Email = "2@test.com",
				DateOfBirth = new DateTime(1958, 10, 10)
			};
			yield return new Customer
			{
				Id = 3000,
				FirstName = "f3",
				LastName = "l3",
				Email = "3@test.com",
				DateOfBirth = new DateTime(1955, 12, 10)
			};
			yield return new Customer
			{
				Id = 4000,
				FirstName = "f4",
				LastName = "l4",
				Email = "4@test.com",
				DateOfBirth = new DateTime(1955, 4, 10)
			};
			yield return new Customer
			{
				Id = 5000,
				FirstName = "f5",
				LastName = "l5",
				Email = "5@test.com",
				DateOfBirth = new DateTime(1958, 6, 10)
			};
			yield return new Customer
			{
				Id = 6000,
				FirstName = "f6",
				LastName = "l6",
				Email = "5@test.com",
				DateOfBirth = new DateTime(1957, 10, 10)
			};
		}
	}
}
