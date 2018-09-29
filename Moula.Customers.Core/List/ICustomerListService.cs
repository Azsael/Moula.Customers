using System.Collections.Generic;
using System.Threading.Tasks;
using Moula.Customers.Core.List.Models;

namespace Moula.Customers.Core.List
{
	public interface ICustomerListService
	{
		Task<IList<CustomerVM>> GetOldCustomers();
	}
}