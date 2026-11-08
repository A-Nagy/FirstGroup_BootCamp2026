


using FirstGroup_1.Domain;

namespace FirstGroup_1.Application.Abstractions.Repositories
{
    public interface IEmployeeRepository :IRepository<Employee>
    { 
        IEnumerable<Employee> GetAllEmployeeWithDepartments();
    }
}
