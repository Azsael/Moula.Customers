using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Moula.Common.Validation.Providers;

namespace Moula.Common.Ioc
{
    public static class CommonBindings
	{
		public static IServiceCollection ConfigureCommon(this IServiceCollection services)
		{
			return services
				.AddSingleton<ILogger>(x => x.GetService<ILoggerFactory>().CreateLogger(""))
				.AddSingleton<IValidationProvider, ValidationProvider>()
				.AddSingleton(typeof(IFactory<>), typeof(Factory<>));
		}
	}
}
