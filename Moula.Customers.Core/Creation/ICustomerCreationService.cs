using System.Threading.Tasks;
using Moula.Common.Foundation.Responses;
using Moula.Customers.Core.Creation.Models;

namespace Moula.Customers.Core.Creation
{
	public interface ICustomerCreationService
	{
		Task<IResponse> CreateCustomer(NewCustomer newCustomer);
	}
}