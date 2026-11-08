


using FirstGroup_1.Application.Abstractions.Repositories;
using FirstGroup_1.Domain;
using FirstGroup_1.Infrastructure.Data;

namespace FirstGroup_1.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IUsersRepository        Users   { get; }

        public IRepository<Category>   Categories { get; }

        public IRepository<Department> Departments { get; }

        public IEmployeeRepository  Employees { get; }

        public IRepository<Permission> Permissions { get; }

        public IRepository<Product>    Products { get; }

        public IRepository<Role>        Roles { get; } 

        public UnitOfWork(ApplicationDbContext Context) 
        {
            _context    = Context;
            Employees   = new EmployeeRepository(_context);
            Categories  = new Repository<Category>(_context);
            Permissions = new Repository<Permission>(_context);
            Products    = new Repository<Product>(_context);
            Roles       = new Repository<Role>(_context);
            Departments = new Repository<Department>(_context);
            Users       = new UsersRepository(_context);

        }
        public int Save()
        {
          return  _context.SaveChanges();
        }
    }
}
