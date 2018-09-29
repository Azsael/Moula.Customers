namespace Moula.Common.Foundation.Responses
{
    public interface IValidationResponse : IResponse, IHasErrorsResponse
    {
    }

    public interface IValidationResponse<out T> : IValidationResponse, IResponse<T>
    {
    }
}