using System;
using System.Collections.Generic;
using Moula.Common.Validation;
using Newtonsoft.Json;

namespace Moula.Common.Foundation.Responses.Types
{
    public class ErrorResponse : IResponse, IHasErrorsResponse, IHasMessageResponse
    {
        public bool IsSuccessful => false;
        public ResponseStatus Status => ResponseStatus.Error;
        public string Message { get; set; }
        public IList<ValidationError> Errors => new[] { new ValidationError { ErrorMessage = Message }, };
    }

    public class ErrorResponse<T> : ErrorResponse, IResponse<T>
    {
        public T Result => default(T);
    }

    public class ExceptionResponse : IResponse
    {
        public bool IsSuccessful => false;
        public ResponseStatus Status => ResponseStatus.Error;

        [JsonIgnore]
        public Exception Exception { get; set; }
    }

    public class ExceptionResponse<T> : ExceptionResponse, IResponse<T>
    {
        public T Result => default(T);
    }
}