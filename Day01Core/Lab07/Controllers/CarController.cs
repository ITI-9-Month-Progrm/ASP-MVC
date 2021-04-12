using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab07.Models;
namespace Lab07.Controllers
{
    public class CarController : Controller
    {
        List<Car> cars = carList.cars;
        public IActionResult Index()
        {
            ViewBag.carsList = cars;
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
            return RedirectToAction("Index");
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
            return RedirectToAction("Index");

        }

        public ActionResult DeleteCar(int id)
        {

            Car deletedCar = cars.FirstOrDefault(c => c.Num == id);
            int res = position(deletedCar.Num);
            if (res < 0) { return View(); }
            else { cars.RemoveAt(res); return RedirectToAction("Index"); }


        }
        private int position(int id)
        {
            int pos = -1;
            foreach (var item in cars)
            {
                if (item.Num == id)
                    ++pos;
            }
            return pos;
        }
    }
}
