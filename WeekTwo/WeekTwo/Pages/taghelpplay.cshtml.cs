using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WeekTwo.Pages
{
    public class taghelpplayModel : PageModel
    {
        public void OnGet()
        {
        }

        [BindProperty]
        public int Number1 { get; set; }

        [BindProperty]
        [Display(Name = "Second Number")]
        public int? Number2 { get; set; }

        [BindProperty]
        public Double Double1 { get; set; }

        [BindProperty]
        [Display(Name = "Second Double")]
        public Double? Double2 { get; set; }

        [BindProperty]
        public Decimal Decimal1 { get; set; }

        [BindProperty]
        [Display(Name = "Second Decimal")]
        public Decimal? Decimal2 { get; set; }

        [BindProperty]
        public float Float1 { get; set; }

        [BindProperty]
        [Display(Name = "Second Float")]
        public float? Float2 { get; set; }

        [BindProperty]
        [DataType(DataType.Date)]
        public DateTime Date1 { get; set; }
    }
}
