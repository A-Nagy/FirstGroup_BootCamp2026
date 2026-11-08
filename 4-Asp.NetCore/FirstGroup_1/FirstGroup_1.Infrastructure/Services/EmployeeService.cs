

using FirstGroup_1.Application.Abstractions.Repositories;
using FirstGroup_1.Application.Abstractions.Services;
using FirstGroup_1.Application.Dtos;
using FirstGroup_1.Domain;

namespace FirstGroup_1.Infrastructure.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddEmployees(CreateEmployeeDto employeeDto)
        {
            var employee = new Employee
            {
                Name         = employeeDto.Name,
                Email        = employeeDto.Email,
                Salary       = employeeDto.Salary,
                Phone        = employeeDto.Phone,
                DepartmentId = employeeDto.DepartedID,
                City         = "Riyadh"

            };
            _unitOfWork.Employees.Add(employee);
      
        }

        public void DeleteEmployees(int id)
        {
          var emp = _unitOfWork.Employees.GetById(id);
            if (emp == null) 
            {
                ;
            }
            _unitOfWork.Employees.Delete(emp);
  
        }

        public IEnumerable<DepartmentDto> GetAllDepartments()
        {
            var departments = _unitOfWork.Departments.GetAll();
            return departments.Select(d => new DepartmentDto
            {
                Id = d.Id,
                Name = d.Name
            });
        
        }

        public IEnumerable<EmployeeListDto> GetAllEmployees()
        {
            var employees = _unitOfWork.Employees.GetAllEmployeeWithDepartments();

           
             return employees.Select(e => new EmployeeListDto
              {
                Id    = e.Id,
                Name  = e.Name,
                Salay = e.Salary,
                DepartedName=e.Department?.Name
              
            });

               




        }

        public UpdateEmployeeDto GetEmployeeById(int id)
        { 
            var employee = _unitOfWork.Employees.GetById(id);
        
            if (employee==null)
            {
                return null; 
            }
        
            return new UpdateEmployeeDto 
                                        {
                                        ID         = employee.Id,
                                        Name       = employee.Name,
                                        Salary     = employee.Salary,
                                        DepartedID = employee.DepartmentId
                                        };
        }

        public int SaveEmployee()
        {
          return _unitOfWork.Save();
        }

        public void UpdateEmployees(UpdateEmployeeDto employeeDto)
        {
            var employee = _unitOfWork.Employees.GetById(employeeDto.ID);
            if (employee == null) 
            {
                throw new KeyNotFoundException("Employee Not Found");
            }
             employee.Name         = employeeDto.Name;
             employee.Email        = employeeDto.Email;
             employee.Salary       = employeeDto.Salary;
             employee.DepartmentId = employeeDto.DepartedID;

            _unitOfWork.Employees.Update(employee);
          
        }
    }
}
