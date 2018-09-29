using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace Moula.Common.Validation.Providers
{
    public class ValidationProvider : IValidationProvider
    {
	    private readonly IServiceProvider _serviceProvider;

        public ValidationProvider(IServiceProvider serviceProvider)
        {
	        _serviceProvider = serviceProvider;
        }

        public ValidationSummary Validate<T>(T t)
        {
	        var validators = _serviceProvider.GetService<IEnumerable<IValidator<T>>>();

	        var validationErrors = validators.SelectMany(x => x.Validate(t)).ToList();
            
            return new ValidationSummary { Errors = validationErrors};
        }
    }
}
