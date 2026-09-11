using System.Diagnostics;
using FirstGroup_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstGroup_1.Controllers
{
    public class HomeController : Controller
    {
         
        public IActionResult Index()
        {
            // return Content("Text Return");
            ViewBag.MyName = "Ahmad";

            //ViewBag.EmployeeName    = "Ahmad";
            //ViewBag.EmployeeEmail   = "Ahmad@gmail";
            //ViewBag.EmployeeAddress = "Cario";
            //ViewBag.EmployeePhone   = "00001";

            //Employee emp = new Employee();
            //emp.Id      = 1;
            //emp.Name    = "Ahmad";
            //emp.Email   = "Ahmad@gmail";
            //emp.Address = "Cario";
            //emp.Phone   = "00001";
            //emp.Salary  = 1000;
            //emp.City    = "Cario";

            //return View(emp);

            // Contune in EmployeeController ****
            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
