using FirstGroup_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstGroup_1.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {

            //Employee emp = new Employee();

            //emp.Id = 1;
            //emp.Name = "Ahmad";
            //emp.Email = "Ahmad@gmail";
            //emp.Address = "Cario";
            //emp.Phone = "00001";
            //emp.Salary = 1000;
            //emp.City = "Cario";

            List<Employee> emps = new List<Employee>();

            Employee emp1 = new Employee()
            {
                Id = 1,
                Name = "Ahmad",
                Email = "Ahmad@gmail",
                Address = "Cario",
                Phone = "00001",
                Salary = 1000,
                City = "Cario"
            };

            Employee emp2 = new Employee()
            {
                Id = 2,
                Name = "Ali",
                Email = "Ali@gmail",
                Address = "Alex",
                Phone = "00002",
                Salary = 2000,
                City = "Alex"
            };

            Employee emp3 = new Employee()
            {
                Id = 3,
                Name = "Omar",
                Email = "Omar@gmail",
                Address = "Giza",
                Phone = "00003",
                Salary = 3000,
                City = "Giza"
            };
            emps.Add(emp1);
            emps.Add(emp2);
            emps.Add(emp3);

            return View(emps);
        }
    }
}
