using IdentityData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchaakModules;
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Schaak.Controllers
{
    public class HomeController : Controller
    {
        readonly ILogger _Ilogger;
        
        public HomeController(ILogger<HomeController> iLogger)
        {
            _Ilogger = iLogger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Email()
        {
            var model = new EmailModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Email([Bind("EmailAddress,Description,Message")] EmailModel emailModel)
        {
            var emailSender = new EmailSender(_Ilogger);
            await emailSender.SendEmailAsync(emailModel.EmailAddress, emailModel.Description, emailModel.Message);

            return View(emailModel);
        }

        public class EmailModel
        {
            [Required]
            [Display(Name = "Email Adress")]
            public string EmailAddress { get; set; }

            [Required]
            public string Description { get; set; }

            [Required]
            public string Message { get; set; }
        }

        public IActionResult Cookie()
        {
            var c1 = Request.Cookies["CookieText"];
            return View(new CookieModel(c1));
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Cookie(string cookieText)
        {
            CookieModel input = new CookieModel(cookieText);
            if (cookieText == null)
            {
                cookieText = "";
            }

            CookieOptions option = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(1)
            };

            Response.Cookies.Append("CookieText", cookieText, option);
            return View(input);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public class CookieModel
        {
            public CookieModel(string cookieText)
            {
                CookieText = cookieText;
            }

            public string CookieText { get; set; }
        }
    }
}
