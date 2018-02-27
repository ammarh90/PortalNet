using DemoPage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoPage.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index(int id)
        {
            CategoryViewModel viewModel = new CategoryViewModel(id);
            return View(viewModel);
        }
    }
}