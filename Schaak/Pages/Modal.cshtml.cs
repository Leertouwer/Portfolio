using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Schaak.Views.Home
{
    public class ModalModel : PageModel
    {
        public void OnGet(string modalurl)
        {
            ViewData["modalurl"] = modalurl;
        }
    }
}