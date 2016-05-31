using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DepClan.Models;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.AspNet.Identity;
using DepClan.ViewModels.Admin;
using Microsoft.AspNet.Authorization;

namespace DepClan.Controllers
{
    public class AdminController : Controller
    {
        #region

        UserManager<ApplicationUser> _userManager;
        public DepContext _context;
        public static List<AdminUserViewModel> usrList = new List<AdminUserViewModel>();
        public static List<SelectListItem> roleList = new List<SelectListItem>();

        #endregion

        public AdminController(UserManager<ApplicationUser> userManager, DepContext depContext)
        {
            _userManager = userManager;
            _context = depContext;
        }

        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> ShowUserDetails(AdminUserViewModel model)
        {
            usrList.Clear();
            IList<ApplicationUser> users = _userManager.Users.ToList();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                model.FirstName = user.FirstName;
                foreach (var role in roles)
                {
                    model.RankName = role;
                    switch (role)
                    {
                        case "Admin":
                            model.RankId = "1"; break;
                        case "Member":
                            model.RankId = "2"; break;
                    }
                }

                model.UserId = user.Id;
                usrList.Add(new AdminUserViewModel() { FirstName = model.FirstName, RankName = model.RankName, UserId = model.UserId, RankId = model.RankId });
                model.RankName = null;
            }
            return PartialView("ShowUserDetails");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Index(AdminUserViewModel model)
        {
            await ShowUserDetails(model);
            return View();
        }
    }
}
