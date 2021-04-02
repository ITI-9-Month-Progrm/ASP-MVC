using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Area_Error__Task.Controllers
{
    public class CustomErrorController : Controller
    {
        // GET: CustomError
        public ActionResult Index()
        {
            string msg = null;

            ViewBag.message = msg.Length;  //Error
            return View();
        }
    }
}