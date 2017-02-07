using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyAbacus.Models
{
    public class MyAbacusViewModel
    {
        private const string ERROR = @"^[-+]?([0-9]*\.[0-9]+|[0-9]+)";

        [Required(ErrorMessage = "Please Enter a Whole Number or decimal")]
        [RegularExpression(ERROR, ErrorMessage = "Please Enter Whole number or Decimal for the frist Number")]
        public string Number1 { get; set; }

        [Required(ErrorMessage = "Please Enter a Whole Number or decimal")]
        [RegularExpression(ERROR, ErrorMessage = "Please Enter Whole number or Decimal for the second Number")]

        public string Number2 { get; set; }
        public string Answer { get; set; }




    }
}