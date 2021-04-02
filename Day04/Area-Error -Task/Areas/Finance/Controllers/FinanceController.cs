using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Area_Error__Task.Areas.Finance.Controllers
{
    public class FinanceController : Controller
    {
        // GET: Finance/Finance
        public ActionResult Index()
        {
            ViewBag.msg = "Hello From Finance";
            return View();
        }
        [HandleError(View = "FinanceError")]
        public ActionResult test()
        {
            string s = null;
            ViewBag.msg = s.Length;

            return View();
        }
    }
}