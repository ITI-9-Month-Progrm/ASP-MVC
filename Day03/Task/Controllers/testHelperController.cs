using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task.Controllers
{
    public class testHelperController : Controller
    {
        // GET: testHelper
        string [] languages = new string[]
        {
            "C", "C++", "C#", "HTML", "JS", "CSS", "Bootstrap"
        };
        public ActionResult getAllLang()
        {
            ViewBag.myList = languages;
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}