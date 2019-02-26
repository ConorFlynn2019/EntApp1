using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntAppSecond.Pages.Students
{
    public class CreateModel : PageModel
    {

        [BindProperty]

        public Models.Student Student { get; set; }


        public void OnGet()
        {

            //if(Student.StudentEmail != Student.EmailReconfirmation)
            //{
             //   ModelState.AddModelError(Student.StudentEmail, "Emails do not match");
            //}
        }
    }
}
