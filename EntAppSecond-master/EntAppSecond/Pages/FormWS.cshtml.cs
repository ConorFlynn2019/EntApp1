using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntAppSecond.Pages
{
    public class FormWSModel : PageModel
    {

        [BindProperty]
        public string ProductCode { get; set; }

        [BindProperty]
        public bool[] Colour { get; set; } = new bool[3];


        public void OnGet()
        {
        }
    }




}
