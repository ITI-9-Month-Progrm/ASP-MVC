using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task.Models;

namespace Task.Controllers
{
    public class EmployeeController : Controller
    {
        EMPLOYEESEntities empContext = new EMPLOYEESEntities();
        // GET: Employee
        public ActionResult Index(int? id)
        {

            SelectList selectListItems = new SelectList(empContext.Depts.ToList(), "DeptID", "DeptName");
            ViewBag.deptList = selectListItems;
            List<Emp> empList = empContext.Emps.ToList();
            if (id != null)
                empList =empContext.Emps.Where(emp => emp.dID == id).ToList();
            return View(empList);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View(empContext.Emps.Find(id));
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            SelectList selectListItems = new SelectList(empContext.Depts.ToList(), "DeptID", "DeptName");
            ViewBag.deptList = selectListItems;
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Emp newEmployee)
        {
            try
            {
                // TODO: Add insert logic here
                Emp newEmp = new Emp();
                newEmp.EmpID = newEmployee.EmpID;
                newEmp.EmpFname = newEmployee.EmpFname;
                newEmp.EmpLname = newEmployee.EmpLname;
                newEmp.EmpSalary = newEmployee.EmpSalary;
                newEmp.EmpHDate = newEmployee.EmpHDate;
                newEmp.dID = newEmployee.dID;
                newEmp.CtyID = newEmployee.CtyID;
                empContext.Emps.Add(newEmp);
                empContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            Emp empEdited = empContext.Emps.Find(id);
            SelectList selectListItems = new SelectList(empContext.Depts.ToList(), "DeptID", "DeptName");
            ViewBag.deptList = selectListItems;
            return View(empEdited);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Emp editedEmp)
        {
            try
            {
                // TODO: Add update logic here
                Emp empEdited = empContext.Emps.Find(id);
                empEdited.EmpFname = editedEmp.EmpFname;
                empEdited.EmpLname = editedEmp.EmpLname;
                empEdited.EmpSalary = editedEmp.EmpSalary;
                empEdited.EmpHDate = editedEmp.EmpHDate;
                empEdited.dID = editedEmp.dID;
                empContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View(empContext.Emps.Find(id));
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Emp removeEmp = empContext.Emps.Find(id);
                empContext.Emps.Remove(removeEmp);
                empContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
