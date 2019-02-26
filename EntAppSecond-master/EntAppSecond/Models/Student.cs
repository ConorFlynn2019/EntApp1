using System;
using System.ComponentModel.DataAnnotations;


namespace EntAppSecond.Pages.Models
{
    public class Student
    {
        public Student()
        {
        }

        [Required (ErrorMessage = "Please enter a Student ID")]
        [Display(Name = "Student ID")]

        public string StudentID { get; set; } = "";

        [Required(ErrorMessage = "Please enter your first name")]
        [Display(Name = "First Name")]

        public string FirstName { get; set; } = "";

        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last Name")]

        public string LastName { get; set; } = "";
    }
}
