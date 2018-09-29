using System.Collections.Generic;
using Moula.Common.Foundation.Responses.Types;
using Moula.Common.Validation;

namespace Moula.Common.Foundation.Responses
{
    public static class ValidationResponseExtensions
    {
        public static IValidationResponse<T> ToValidationResponse<T>(this T t)
        {
            if (t == null)
                return new NotFoundValidationResponse<T>();

            return new ValidationResponse<T>
            {
                Result = t
            };
        }
        
        public static IValidationResponse<T> ToValidationResponse<T>(this ValidationSummary validationSummary)
        {
            return new ValidationResponse<T> { Errors = validationSummary.Errors };
        }
        
        public static IValidationResponse<T> ToValidationResponse<T>(this IList<ValidationError> errors)
        {
            return new ValidationResponse<T> { Errors = errors };
        }
    }
}