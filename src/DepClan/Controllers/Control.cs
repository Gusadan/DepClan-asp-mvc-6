using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepClan.Controllers
{
    public class Control : Controller
    {
        public IActionResult Admin()
        {
            return View();
        }
    }
}
