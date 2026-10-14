using FirstGroup_1.Data;
using FirstGroup_1.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstGroup_1.Repositories.Employees
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
         

    }
}
