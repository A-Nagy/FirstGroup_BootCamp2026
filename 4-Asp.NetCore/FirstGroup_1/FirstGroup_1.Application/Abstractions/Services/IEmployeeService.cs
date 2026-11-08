


using FirstGroup_1.Application.Dtos;

namespace FirstGroup_1.Application.Abstractions.Services
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeListDto> GetAllEmployees();
        UpdateEmployeeDto GetEmployeeById(int id);
        void AddEmployees(CreateEmployeeDto employeeDto);
        void UpdateEmployees(UpdateEmployeeDto employeeDto);
        void DeleteEmployees(int id);
        IEnumerable<DepartmentDto> GetAllDepartments();
        int SaveEmployee();
    }
}
