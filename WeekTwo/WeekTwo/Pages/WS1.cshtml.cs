using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WeekTwo.Pages
{
    public class WS1Model : PageModel
    {
        public string Message { get; set; }


        public void OnGet(){

            Message = "Hello";
        }

        public string[] MyTestArray { get; set; } = { "England", "Scotland", "Ireland", "Wales" };



        [BindProperty]
        public string UserName { get; set; }


        /*used when info isnt compulsory! Doesnt have as many pre-completed info as above
        [BindProperty]
        public int? NumberOne { get; set; }
        */

        public void OnPost(){

            Message = String.Format("Hello {0}!", UserName);
        }
    }
}
