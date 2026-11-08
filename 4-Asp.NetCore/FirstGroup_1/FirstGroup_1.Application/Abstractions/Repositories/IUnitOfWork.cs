


using FirstGroup_1.Domain;

namespace FirstGroup_1.Application.Abstractions.Repositories
{
    public interface IUnitOfWork
    {
        IUsersRepository  Users { get; }
        IRepository<Category> Categories { get; }
        IRepository<Department> Departments { get; }
        IEmployeeRepository Employees { get; }
        IRepository<Permission> Permissions { get; }
        IRepository<Product> Products { get; }
        IRepository<Role> Roles { get; }

        int Save();
 

    }
}
