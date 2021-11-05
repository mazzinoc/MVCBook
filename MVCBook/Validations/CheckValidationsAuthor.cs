using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBook.Validations
{
    public class CheckValidationsAuthor: ValidationAttribute
    {
        public CheckValidationsAuthor()
        {
            ErrorMessage = "The field Author must be a string with a maximum lenght of 50";
        }
        public override bool IsValid(object value)
        {
            string Author = Convert.ToString(value);
            if (Author.Length > 50)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}