using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task.Models
{
    public class GenderAnnotation : ValidationAttribute
    {
        string Value;
        public GenderAnnotation(string gender)
        {
            Value = gender;
        }
        protected override ValidationResult IsValid(object obj, ValidationContext validationContext)
        {
            if (obj != null)
            {
                if (obj is string)
                {
                    string suppliedValue = (string)obj;
                    if (suppliedValue.ToLower() == "male" && suppliedValue.ToLower() == "female")
                    {
                        //user validation error
                        return new ValidationResult("The gender should be male or female");
                    }
                }
            }
            return ValidationResult.Success;
        }
    }
}