using FirstGroup_1.Data;
using FirstGroup_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstGroup_1.Controllers
{
    public class EmployeesController : Controller
    {
        //// Old code for Index action method
        //public IActionResult Index()
        //{

        //    //Employee emp = new Employee();

        //    //emp.Id = 1;
        //    //emp.Name = "Ahmad";
        //    //emp.Email = "Ahmad@gmail";
        //    //emp.Address = "Cario";
        //    //emp.Phone = "00001";
        //    //emp.Salary = 1000;
        //    //emp.City = "Cario";

        //    List<Employee> emps = new List<Employee>();

        //    Employee emp1 = new Employee()
        //    {
        //        Id = 1,
        //        Name = "Ahmad",
        //        Email = "Ahmad@gmail",
        //        Address = "Cario",
        //        Phone = "00001",
        //        Salary = 1000,
        //        City = "Cario"
        //    };

        //    Employee emp2 = new Employee()
        //    {
        //        Id = 2,
        //        Name = "Ali",
        //        Email = "Ali@gmail",
        //        Address = "Alex",
        //        Phone = "00002",
        //        Salary = 2000,
        //        City = "Alex"
        //    };

        //    Employee emp3 = new Employee()
        //    {
        //        Id = 3,
        //        Name = "Omar",
        //        Email = "Omar@gmail",
        //        Address = "Giza",
        //        Phone = "00003",
        //        Salary = 3000,
        //        City = "Giza"
        //    };

        //    Employee emp4 = new Employee()
        //    {
        //        Id = 4,
        //        Name = "Fatimah",
        //        Email = "Fatimah@gmail",
        //        Address = "Rayadh",
        //        Phone = "00003",
        //        Salary = 3000,
        //        City = "Gada"
        //    };

        //    emps.Add(emp1);
        //    emps.Add(emp2);
        //    emps.Add(emp3);
        //    emps.Add(emp4);

        //    return View(emps);
        //}


        // New code for Employees action methods ************** 

        // Inject the ApplicationDbContext into the controller

        //Dependency injection is used to provide the controller with an instance of the ApplicationDbContext,
        //which allows it to interact with the database.

        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }



        [HttpGet]
        public IActionResult Index()
        {
            // Retrieve the list of employees from the database using Entity Framework
            // 'ToList()' It Equal Select all employees from the Employees table in the database and convert them to a list.
           
            List<Employee> Employees =  _context.Employees.ToList();

            return View(Employees);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(emp);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(emp);
      
        }
    }
}