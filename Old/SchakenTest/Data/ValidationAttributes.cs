using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Schaken.Data.ValidationAttributes
{
    
    public class VanafOverTienDagenAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            value = (DateTime)value;
            if (DateTime.Now.AddDays(10).CompareTo(value) <= 0 && DateTime.Now.AddYears(1).CompareTo(value) >= 0)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Date must be 10 days and less then 1 year from now.");
            }
        }
    }
}
