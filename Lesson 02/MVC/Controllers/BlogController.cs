using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("article-1")]
        public ActionResult Article1()
        {
            return View("Article1");
        }

        [ActionName("article-2")]
        public ActionResult Article2()
        {
            return View("Article2");
        }
    }
}