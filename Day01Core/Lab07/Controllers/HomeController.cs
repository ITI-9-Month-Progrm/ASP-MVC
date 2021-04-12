using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab07.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.msg = "Hello World";
            return View();
        }
    }
}
