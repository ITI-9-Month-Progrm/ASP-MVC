using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Area_Error__Task.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Admin
        public ActionResult Index()
        {
            ViewBag.msg = "Hello From Admin";
            return View();
        }
        [HandleError(View="AdminError")]
        public ActionResult test()
        {
            string s = null;
            ViewBag.msg = s.Length;

            return View();
        }
    }
}