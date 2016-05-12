using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using DepClan.Models;
using Microsoft.AspNet.Authorization;
using DepClan.Services;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DepClan.Controllers
{
    public class ContactController : Controller
    {
        private IMailService _iMailService;

        public ContactController(IMailService iMailService)
        {
            _iMailService = iMailService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Query queryModel)
        {
            if (ModelState.IsValid)
            {
                var email = Startup.Configuration["AppSettings:SiteEmailAddress"];

                if (string.IsNullOrWhiteSpace(email))
                {
                    ModelState.AddModelError("", "Could not send email. Configuration problem.");
                }

                if(_iMailService.SendMail(
                    email,
                    email,
                    $"Contact Page from {queryModel.FirstName} {queryModel.LastName} ({queryModel.Email})",
                    queryModel.Message))
                {
                    ModelState.Clear();

                    ViewBag.Message = "Message has ben sent. Thank you!";
                }
            }
            return View();
        }
    }
}
