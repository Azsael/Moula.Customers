using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moula.Common.Foundation.Responses;
using Moula.Customers.Core.Creation;
using Moula.Customers.Core.Creation.Models;
using Moula.Customers.Core.List;
using Moula.Customers.Core.List.Models;

namespace Moula.Customers.API.Controllers
{
    [Route("v1/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
	    private readonly ICustomerCreationService _customerCreationService;
	    private readonly ICustomerListService _customerListService;

	    public CustomersController(ICustomerCreationService customerCreationService, ICustomerListService customerListService)
	    {
		    _customerCreationService = customerCreationService;
		    _customerListService = customerListService;
	    }

		[HttpGet]
        public Task<IList<CustomerVM>> GetOldCustomers()
		{
			return _customerListService.GetOldCustomers();
		}

		[HttpPost]
        public Task<IResponse> CreateCustomer(NewCustomer newCustomer)
		{
			return _customerCreationService.CreateCustomer(newCustomer);
		}
    }
}
