using System;
using Microsoft.Extensions.DependencyInjection;

namespace Moula.Common
{
	internal class Factory<T> : IFactory<T>
	{
		private readonly IServiceProvider _serviceProvider;

		public Factory(IServiceProvider serviceProvider)
		{
			_serviceProvider = serviceProvider;
		}

		public T Create()
		{
			return _serviceProvider.GetService<T>();
		}
	}
}