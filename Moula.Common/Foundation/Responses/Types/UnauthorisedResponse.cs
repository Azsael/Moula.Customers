using System.Collections.Generic;
using Moula.Common.Validation;

namespace Moula.Common.Foundation.Responses.Types
{
    public class UnauthorisedResponse : IResponse, IHasErrorsResponse, IHasMessageResponse
    {
        public bool IsSuccessful => false;
        public ResponseStatus Status => ResponseStatus.Unauthorised;
        public string Message { get; set; }
        public IList<ValidationError> Errors => new[] { new ValidationError { ErrorMessage = Message } };
    }

    public class UnauthorisedResponse<T> : UnauthorisedResponse, IResponse<T>
    {
        public T Result => default(T);
    }
}