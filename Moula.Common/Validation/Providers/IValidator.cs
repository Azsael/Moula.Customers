using System.Collections.Generic;

namespace Moula.Common.Validation.Providers
{
    public interface IValidator<in T>
    {
        IEnumerable<ValidationError> Validate(T t);
    }
}