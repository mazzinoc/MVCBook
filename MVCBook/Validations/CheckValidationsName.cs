using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCBook.Validations
{
    public class CheckValidationsName:ValidationAttribute
    {
        public CheckValidationsName()
        {
            ErrorMessage = "The name field is required";
        }
        public override bool IsValid(object value)
        {
            string name = Convert.ToString(value);
            if (name == null)
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