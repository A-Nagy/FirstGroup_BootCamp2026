using FirstGroup_1.Data;
using FirstGroup_1.Models;
using FirstGroup_1.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FirstGroup_1.Controllers
{
    [Authorize]
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


        [Authorize(Policy =PermissionsNames.EmployeeView)]
        [HttpGet]
        public IActionResult Index()
        {
            // Retrieve the list of employees from the database using Entity Framework
            // 'ToList()' It Equal Select all employees from the Employees table in the database and convert them to a list.
           
            List<Employee> Employees =  _context.Employees.Include(e => e.Department).ToList();
            //include() Load Realeted Department Data
            return View(Employees);
        }
        // Content : Text 
        // View    : interface / Screen
        // NotFound: Error Screen
        // Ok     : Api (Data In Json)
        // BadRequest: Error For Api
        // RedirectTo Action() : Retrive Data from Anther Action

        [HttpGet]
        public IActionResult GetAllEmployees()
        {

            //  List<Employee> Employees = _context.Employees.Include(e => e.Department).ToList();
            List<Employee> Employees = _context.Employees.ToList();
            return Ok(Employees);
            // View()     : Screen
            // NotFound() : Not Found Screen
            // Content()  : Text
            // Ok()       : Data
            // BadRequest() :Error Data
            // RedirectTo Action() : Retrive Data from Anther Action
        }
        [Authorize(Roles ="Admin")]
        public IActionResult Details(int Id)
        {
            Employee? emp = _context.Employees.Include(e => e.Department).FirstOrDefault(e=> e.Id==Id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }
        [Authorize(Policy = PermissionsNames.EmployeeCreate)]
        [HttpGet]
        public IActionResult Create() 
        {
            LoadDepartments();
            return View();
        }
        [Authorize(Policy = PermissionsNames.EmployeeCreate)]
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
          //  LoadDepartments();
            return View(emp);
      
        }
        [Authorize(Policy =PermissionsNames.EmployeeEdit)]
        [HttpGet]
        public IActionResult Update(int Id) 
        {
           Employee? emp = _context.Employees.Find(Id);
            if (emp == null)
            {
                return NotFound();
            }
            LoadDepartments();
            return View(emp);
        }
        [Authorize(Policy = PermissionsNames.EmployeeEdit)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Update(employee);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            LoadDepartments();
            return View(employee);
        }
        [HttpGet]
        [Authorize(Policy = PermissionsNames.EmployeeDelete)]
        public IActionResult Delete(int Id)
        {
            Employee? emp = _context.Employees.Find(Id);
            if (emp == null)
            {
                return NotFound();
            }
            LoadDepartments();
            return View(emp);
        }
        [Authorize(Policy = PermissionsNames.EmployeeDelete)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Employee employee)
        {
            
                _context.Employees.Remove(employee);
                _context.SaveChanges();
                return RedirectToAction("Index");
           
          
        }
        private void LoadDepartments()
        {
            IEnumerable<Department> departments =_context.Departments.ToList();
            ViewBag.Departments = new SelectList(departments,"Id","Name");
        }

    }
}