using Microsoft.AspNet.Mvc;

using DepClan.Models;
using Microsoft.AspNet.Authorization;

namespace DepClan.Controllers
{
    [Authorize]
    public class PersonController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var persons = new PersonDatabase();
            return View(persons);
        }
    }
}