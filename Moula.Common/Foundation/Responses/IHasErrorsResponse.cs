using System.Collections.Generic;
using Moula.Common.Validation;

namespace Moula.Common.Foundation.Responses
{
    public interface IHasErrorsResponse
    {
        IList<ValidationError> Errors { get; }
    }
}