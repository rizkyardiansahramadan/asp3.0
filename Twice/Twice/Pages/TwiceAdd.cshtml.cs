using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Twice.Model;

namespace Twice.Pages
{
    public class TwiceAddModel : PageModel
    {
        KonekDb db = new KonekDb();
        [BindProperty]
        public DataTwice tw { get; set; }
        public IActionResult OnGet(string action, string id)
        {
            if (action != null && id != null)
            {
                ProsesTwice proses = new ProsesTwice();
                switch (action.ToUpper())
                {
                    case "EDIT":
                        tw = proses.getTwiceById(id);
                        break;
                    case "DELETE":
                        if (proses.deleteTwice(id))
                        {
                            return new RedirectToPageResult("/Twice");
                        }
                        break;
                    default:
                        break;

                }

            }
            return Page();
        }
        public IActionResult OnPost()
        {
            ProsesTwice proses = new ProsesTwice();
            if (tw.id != 0)
            {
                if (proses.UpdateTwice(tw))
                {
                    return new RedirectToPageResult("/Twice");
                }
            }
            else
            {
                if (proses.saveTwice(tw))
                {
                    return new RedirectToPageResult("/Twice");
                }
            }
            return Page();
        }
    }
}
