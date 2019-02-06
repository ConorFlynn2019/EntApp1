using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WeekTwo.Pages
{
    public class WS1BModel : PageModel
    {
        public string Result { get; set; }

        public string Message { get; set; }


        [BindProperty]
        public int NumberOne { get; set; }
        [BindProperty]
        public int NumberTwo { get; set; }

        public void OnGet()
        {
        }

        public void OnPost(int NumberOne, int NumberTwo, string type)
        {
            Result = String.Format("{0} plus {1} equals {2}", NumberOne, NumberTwo, (NumberOne + NumberTwo));

            switch (type)
            {
                case "plus":

                    Message = $"{NumberOne} plus {NumberTwo} equals {NumberOne + NumberTwo}";
                    break;

                case "minus":

                    Message = $"{NumberOne} minus {NumberTwo} equals {NumberOne - NumberTwo}";
                    break;

                case "multiply":

                    Message = $"{NumberOne} multiply by {NumberTwo} equals {NumberOne * NumberTwo}";
                    break;

                case "divide":

                    Message = $"{NumberOne} divided by {NumberTwo} equals {NumberOne / NumberTwo}";
                    break;


            }
        }
    }
}