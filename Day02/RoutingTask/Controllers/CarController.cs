using RoutingTask.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingTask.Controllers
{
    
    public class CarController : Controller
    {
        static List<Car> cars = new List<Car>()
            {
                new Car(){Num=1,Color="red",Model="AS123",Manfacture="Marcidase"},
                new Car(){Num=2,Color="blue",Model="AS123",Manfacture="Marcidase"},
                new Car(){Num=3,Color="green",Model="AS123",Manfacture="Marcidase"},
                new Car(){Num=4,Color="red",Model="AS123",Manfacture="Marcidase"},
                new Car(){Num=5,Color="yellow",Model="AS123",Manfacture="Marcidase"}
            };

        // GET: Car
        public ActionResult GetAllCars()
        {
            ViewBag.carList = cars;
            return View();
        }
        public ActionResult CarDetails(int id)
        {
            Car selectedCar = cars.FirstOrDefault(c => c.Num == id);
            ViewBag.selectedCar = selectedCar;
            return View();
        }

        
        public ActionResult EditCar(int id)
        {
          
            Car editedCar = cars.FirstOrDefault(c => c.Num == id);
            
            ViewBag.editedCar = editedCar;
            return View();
        }
       [HttpPost]
        public ActionResult EditCar(int id, string color, string model, string manfactour)
        {

            Car editedCar = cars.FirstOrDefault(c => c.Num == id);
            editedCar.Color = color;
            editedCar.Model = model;
            editedCar.Manfacture = manfactour;
            ViewBag.editedCar = editedCar;
            return RedirectToAction("GetAllCars");
        }

        public ActionResult CreateCar()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult CreateCar(int id, string color, string model, string manfactour)
        {

            Car newCar = new Car();
            newCar.Num = id;
            newCar.Color = color;
            newCar.Model = model;
            newCar.Manfacture = manfactour;
            cars.Add(newCar);
            return RedirectToAction("GetAllCars");

        }
        
        public ActionResult DeleteCar(int id)
        {

            Car deletedCar = cars.FirstOrDefault(c => c.Num == id);
            int res = position(deletedCar.Num);
            if (res < 0) { return View("Error"); } 
            else { cars.RemoveAt(res); return RedirectToAction("GetAllCars"); }
          
           
        }
        private int position(int id)
        {
            int pos = -1;
                    foreach(var item in cars)
                            {
                if (item.Num == id)
                    ++pos;
                            }
            return pos;
        }


        public ActionResult Index()
        {
            return View();
        }
    }
}