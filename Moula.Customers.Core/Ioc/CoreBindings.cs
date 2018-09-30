using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using Moula.Common.Validation.Providers;
using Moula.Customers.Core.Creation;
using Moula.Customers.Core.Creation.Models;
using Moula.Customers.Core.Creation.Validators;
using Moula.Customers.Core.List;
using Moula.Customers.Entities.Ioc;
[assembly: InternalsVisibleTo("Moula.Customers.Core.Tests")]

namespace Moula.Customers.Core.Ioc
{
    public static class CoreBindings
	{
		public static IServiceCollection ConfigureCore(this IServiceCollection services)
		{
			return services
				.ConfigureEntities()
				.AddSingleton<ICustomerCreationService, CustomerCreationService>()
				.AddSingleton<ICustomerListService, CustomerListService>()
				.AddSingleton<IValidator<NewCustomer>, CustomerCreationValidator>();
		}
	}
}
