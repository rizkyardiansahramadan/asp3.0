using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Twice.Model;

namespace Twice.Pages
{
    public class TwiceModel : PageModel
    {
        [BindProperty]
        public List<DataTwice> DataTwice { get; set; }

        public IActionResult OnGet()
        {
            ProsesTwice proses = new ProsesTwice();
            DataTwice = proses.getTwice();
            return Page();
        }
    }
}
