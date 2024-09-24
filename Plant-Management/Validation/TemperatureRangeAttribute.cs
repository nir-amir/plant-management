using System.ComponentModel.DataAnnotations;
using Plant_Management.Models;

namespace Plant_Management.Validation;

public class TemperatureRangeAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {
        if (validationContext == null || value == null)
        {
            return ValidationResult.Success;
        }
        
        var plant = (Plant)validationContext.ObjectInstance;
        
        return plant.MinTemperature > plant.MaxTemperature ? 
            new ValidationResult("MaxTemperature must be greater than MinTemperature") : ValidationResult.Success;
    }
}