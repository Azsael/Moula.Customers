using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Moula.Customers.Entities.Context;

namespace Moula.Customers.Entities.Ioc
{
    public static class EntityBindings
	{
		public static IServiceCollection ConfigureEntities(this IServiceCollection services)
		{
			return services
				.AddTransient<ICustomerContext, CustomerContext>()
				.AddDbContext<CustomerContext>(options => options.UseInMemoryDatabase(Guid.NewGuid().ToString()), ServiceLifetime.Transient, ServiceLifetime.Singleton);
		}
	}
}
