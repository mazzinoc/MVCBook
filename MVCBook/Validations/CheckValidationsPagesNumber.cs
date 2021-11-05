using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCBook.Validations
{
    public class CheckValidationsPagesNumber:ValidationAttribute
    {
        public CheckValidationsPagesNumber()
        {
            ErrorMessage = "The field PagesNumber must be between 100 and 10000.";
        }
        public override bool IsValid(object value)
        {
            int pages = (int)value;
            if (pages<100 || pages>10000)
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