using System.Collections.Generic;
using System.Linq;

namespace Moula.Common.Validation
{
    public class ValidationSummary
    {
        public bool IsValid => Errors == null || !Errors.Any();
        public bool IsInvalid => Errors?.Any() == true;
		
        public IList<ValidationError> Errors { get; set; }
    }
}