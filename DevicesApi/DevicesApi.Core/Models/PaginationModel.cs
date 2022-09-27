using System.ComponentModel.DataAnnotations;

namespace DevicesApi.Core.Models
{
    public class PaginationModel : IValidatableObject
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (PageNumber < 1)
                yield return new ValidationResult("Page number must be 1 or higher");

            if (PageSize < 1 || PageSize > 100)
                yield return new ValidationResult("Page size must be at least 1 and lower than 100");
        }
    }
}
