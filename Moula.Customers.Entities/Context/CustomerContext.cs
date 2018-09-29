using Microsoft.EntityFrameworkCore;
using Moula.Customers.Entities.Models;

namespace Moula.Customers.Entities.Context
{
	internal class CustomerContext : DbContext, ICustomerContext
	{
		public DbSet<Customer> Customers { get; set; }

		public CustomerContext(DbContextOptions options) : base(options) { }
	}
}