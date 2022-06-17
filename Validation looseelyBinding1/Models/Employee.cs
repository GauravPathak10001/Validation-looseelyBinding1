using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Validation_looseelyBinding1.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Please enter correct firstName.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Please enter correct lastName")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Please enter correct email address")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please enter correct age range between 18 to 75")]
        [Range(18,75)]
        public int Age { get; set; }
    }
}