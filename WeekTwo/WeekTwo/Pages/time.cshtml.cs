using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WeekTwo.Pages
{
    public class timeModel : PageModel
    {
        public string[] DaysOfWeek { get; set; } = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"
        , "Saturday", "Sunday" };


        [BindProperty]
        public bool[] IsDayChosen { get; set; } = new bool[7];


        [BindProperty]

        public string[] MonthsChosen { get; set; } = { };


        public List<SelectListItem> MonthList { get; set; } =

            new List<SelectListItem>
            {
                new SelectListItem("January", "January"),
                new SelectListItem("February", "February"),
                new SelectListItem("March", "March"),
                new SelectListItem("April", "April"),
                new SelectListItem("May", "May"),
                new SelectListItem("June", "June")

            };

        public void OnGet()
        {
        }
    }
}