using System;
using System.ComponentModel.DataAnnotations;

namespace HelloWorldProject.Models
{
    public class Employee
    {
        //name
        //validation
        [Required(ErrorMessage ="Please enter employee name")]
        public string name { get; set; }

        //department
        [Required(ErrorMessage ="Please enter department name")]
        public string department { get; set; }

        //is active
        public bool isActive { get; set; }

        //new properties
        [Required(ErrorMessage ="Job title is missing")]
        [DataType(DataType.Text)]
        public string jobTitle { get; set; }

        [Required(ErrorMessage = "Birthdate is missing")]
        [DataType(DataType.Date)]
        public DateTime birthDate { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email is missing")]
        public string email { get; set; }
    }
}
