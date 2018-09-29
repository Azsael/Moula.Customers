namespace Moula.Common.Validation
{
    public class ValidationError
    {
        public bool IsFieldError => !string.IsNullOrWhiteSpace(FieldName);
        public string FieldName { get; set; }
        public string ErrorMessage { get; set; }
        
        public ValidationError()
        {
        }

        public ValidationError(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        public ValidationError(string fieldName, string errorMessage)
        {
            FieldName = fieldName;
            ErrorMessage = errorMessage;
        }
    }
}