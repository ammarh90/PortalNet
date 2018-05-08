using DemoPage.Database;
using DemoPage.Database.Entity;
using DemoPage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoPage.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            LoginViewModel viewModel = new LoginViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult CheckLogin(string username, string password)
        {

            using (var dtx = new DataContext())
            {
                var user = dtx.Users.Where(item => item.UserName == username).Where(item => item.Password==password).FirstOrDefault();

                if(user != null)
                {
                    Session["UserId"] = user.UserId;
                    return Redirect("/Home");
                }
                else
                {
                    TempData["LoginError"] = "Korisnički podaci netačni! ";
                    return Redirect("/Login");
                }
            }

        }

        public ActionResult Logout()
        {
            Session.Remove("UserId");
            return Redirect("/Home");
        }
    }
}