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
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            RegistrationViewModel viewModel = new RegistrationViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult MakeRegistration(string firstname, string lastname, string email, string username, string password, string confirmpassword)
        {
            RegistrationViewModel viewModel = new RegistrationViewModel();

            if (firstname == null || firstname == "")
            {
                TempData["RegistrationError"] = "Molimo Vas unesite ime!";
                return Redirect("/Registration");
            }
            
            if(lastname == null || lastname == "")
            {
                TempData["RegistrationError"] = "Molimo Vas unesite prezime";
                return Redirect("/Registration");
            }

            if(email == null || email== "")
            {
                TempData["RegistrationError"] = "Molimo Vas unesite email";
                return Redirect("/Registration");
            }

            if (password == null || password == "")
            {
                TempData["RegistrationError"] = "Molimo Vas unesite lozinku";
                return Redirect("/Registration");
            }

            if (confirmpassword == null || confirmpassword == "")
            {
                TempData["RegistrationError"] = "Molimo Vas potvrdite lozinku";
                return Redirect("/Registration");
            }

            if (!viewModel.IsValidEmail(email))
            {
                TempData["RegistrationError"] = "Email adresa nije validna!";
                return Redirect("/Registration");
            }

            if (password != confirmpassword)
            {
                TempData["RegistrationError"] = "Potvrda lozinke nije tacna!";
                return Redirect("/Registration");
            }

            using(var dtx = new DataContext())
            {
                var checkUsername = dtx.Users.Where(item => item.UserName == username).Count();
                if(checkUsername > 0)
                {
                    TempData["RegistrationError"] = "Korisnicko ime je zauzeto!";
                    return Redirect("/Registration");
                }

                User newUser = new User();
                newUser.FirstName = firstname;
                newUser.LastName = lastname;
                newUser.Email = email;
                newUser.UserName = username;
                newUser.Password = password;

                dtx.Users.Add(newUser);
                dtx.SaveChanges();

                TempData["RegistrationSuccess"] = "Uspjesno ste se registrovali!";
                return Redirect("/Registration");
            }
            return Redirect("/Registration");
        }

    }
}