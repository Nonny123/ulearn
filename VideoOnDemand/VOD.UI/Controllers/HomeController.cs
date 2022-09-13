using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using VOD.Common.Entities;
using VOD.UI.Models;
using System.Diagnostics;
using VOD.Database.Services;
//using VOD.UI.Models;

namespace VOD.UI.Controllers
{
    public class HomeController : Controller
    {
        #region Properties
        private readonly SignInManager<VODUser> _signInManager;
        #endregion

        #region Constructor
        public HomeController(SignInManager<VODUser> signInMgr)
        {
            _signInManager = signInMgr;
        }
        #endregion

        #region Actions
        public IActionResult Index()
        {
            if (!_signInManager.IsSignedIn(User))
                return RedirectToPage("/Account/Login", new { Area = "Identity" });

            return RedirectToAction("Dashboard", "Membership");
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
        #endregion
    }
}
