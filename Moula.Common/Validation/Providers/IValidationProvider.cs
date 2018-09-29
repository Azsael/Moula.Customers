namespace Moula.Common.Validation.Providers
{
    public interface IValidationProvider
    {
        ValidationSummary Validate<T>(T t);
    }
}