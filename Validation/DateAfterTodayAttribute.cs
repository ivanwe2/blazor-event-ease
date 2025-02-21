using System.ComponentModel.DataAnnotations;

namespace EventEase.Validation;

public class DateAfterTodayAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {
        if (value is DateTime dateTime)
        {
            if (dateTime > DateTime.Now)
            {
                return ValidationResult.Success!;
            }
            else
            {
                return new ValidationResult(ErrorMessage ?? "Date must be after today.");
            }
        }
        return new ValidationResult("Invalid date format.");
    }
}