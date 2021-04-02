using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Area_Error__Task.Areas.HR.Controllers
{
    public class HRController : Controller
    {
        // GET: HR/HR
        public ActionResult Index()
        {
            ViewBag.msg = "Hello From HR";
            return View();
        }
        [HandleError(View = "HRError")]
        public ActionResult test()
        {
            string s = null;
            ViewBag.msg = s.Length;

            return View();
        }
    }
}