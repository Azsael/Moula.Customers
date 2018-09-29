using System.Collections.Generic;

namespace Moula.Common.Validation
{
    public static class ValidationConstants
    {
        public static readonly IList<ValidationError> NoErrors = new ValidationError[0];

        public static IList<ValidationError> ToList(this ValidationError validationError)
        {
            return new[] {validationError};
        }
    }
}