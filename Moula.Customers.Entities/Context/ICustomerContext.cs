using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moula.Customers.Entities.Models;

namespace Moula.Customers.Entities.Context
{

	public interface ICustomerContext
	{
		DbSet<Customer> Customers { get; set; }

		Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
	}
}
