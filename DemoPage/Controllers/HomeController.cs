using DemoPage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoPage.Controllers
{
    public class HomeController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            HomeIndexViewModel viewModel = new HomeIndexViewModel();

            return View(viewModel);
        }

        public ActionResult Contact()
        {
            BaseViewModels viewModel = new BaseViewModels();
            return View(viewModel);
        }
    }
}