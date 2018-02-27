using DemoPage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoPage.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index(int id)
        {
            ArticleViewModel viewModel = new ArticleViewModel(id);
            return View(viewModel);
        }
    }
}