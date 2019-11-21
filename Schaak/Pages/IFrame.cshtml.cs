using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Schaak.Views.Home
{
    public class IFrameModel : PageModel
    {
        public void OnGet(string iframeurl)
        {
            ViewData["iframeurl"] = iframeurl;
        }
    }
}