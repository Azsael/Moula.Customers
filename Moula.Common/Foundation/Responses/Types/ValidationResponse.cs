using System.Collections.Generic;
using System.Linq;
using Moula.Common.Validation;

namespace Moula.Common.Foundation.Responses.Types
{
    public class ValidationResponse : IValidationResponse
    {
        public bool IsSuccessful => Status == ResponseStatus.Success || Status == ResponseStatus.SuccessButWarnings;

        public ResponseStatus Status => Errors?.Any() == true ? ResponseStatus.Invalid : ResponseStatus.Success;
		
        public IList<ValidationError> Errors { get; set; }
    }

    public class ValidationResponse<T> : ValidationResponse, IValidationResponse<T>
    {
        public T Result { get; set; }
    }
}