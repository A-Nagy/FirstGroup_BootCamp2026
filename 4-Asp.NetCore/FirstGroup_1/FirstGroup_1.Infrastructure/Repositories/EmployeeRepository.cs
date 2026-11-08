
using FirstGroup_1.Application.Abstractions.Repositories;
using FirstGroup_1.Domain;
using FirstGroup_1.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FirstGroup_1.Infrastructure.Repositories
{
    public class EmployeeRepository : Repository<Employee>,IEmployeeRepository
    {


        public EmployeeRepository(ApplicationDbContext context) : base(context) { }
       
        public IEnumerable<Employee> GetAllEmployeeWithDepartments()
        {
           return _context.Employees.Include(e=>e.Department).ToList();
        }
    }
}
