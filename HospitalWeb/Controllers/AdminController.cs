
using HospitalDataLayer.Respo;
using HospitalModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HospitalWeb.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult AdminLogin()
        {
            return View();
        }

        
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult AdminLogin(Admin model)
        {

            ClassManager classmanager = new ClassManager();
                string password = classmanager.GetUserPassword(model.Email);

                if (string.IsNullOrEmpty(password))
                    ModelState.AddModelError("", "The user login or password provided is incorrect.");
                else
                {
                    if (model.Password.Equals(password))
                    {
                        FormsAuthentication.SetAuthCookie(model.Email, false);
                        return RedirectToAction("Index", "Admin");
                    }
                    else
                    {
                        ModelState.AddModelError("", "The password provided is incorrect.");
                    }
                }
            

            // If we got this far, something failed, redisplay form
            return View(model);
        }
    }
}