using System;
using System.ComponentModel.DataAnnotations;


namespace EntAppSecond.Pages.Models
{
    public class Student
    {
        public Student()
        {
        }

        [Required(ErrorMessage = "Please enter a Student ID")]
        [Display(Name = "Student ID")]
        [RegularExpression(@"(S|s)\d{8}")]

        public string StudentID { get; set; } = "";

        [Required(ErrorMessage = "Please enter your first name")]
        [Display(Name = "First Name")]
        [RegularExpression(@"\w{2,50}")]

        public string FirstName { get; set; } = "";

        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last Name")]
        [RegularExpression("[\\w'-]{3,}")]

        public string LastName { get; set; } = "";

        [Required(ErrorMessage = "Please enter your date of birth")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        //[RegularExpression()]

        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Please enter your number of modules")]
        [Display(Name = "Number of Modules")]
        [Range(1, 10)]
        //[RegularExpression()]
        public int Modules { get; set; }


        [Required(ErrorMessage = "Please enter your height")]
        [Display(Name = "Height in CM")]
        //[RegularExpression()]
        public int Height { get; set; }

        [EmailAddress]
        public EmailAddressAttribute StudentEmail { get; set; }


        [EmailAddress]
        public EmailAddressAttribute EmailReconfirmation { get; set; }

    }
}
