using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewCategory(string CategoryName)
        {
            ViewBag.CategoryName = "You selected: " + CategoryName;
            return View();
        }

    }
}