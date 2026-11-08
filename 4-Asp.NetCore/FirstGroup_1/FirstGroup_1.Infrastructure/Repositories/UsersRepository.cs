
using FirstGroup_1.Application.Abstractions.Repositories;
using FirstGroup_1.Domain;
using FirstGroup_1.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FirstGroup_1.Infrastructure.Repositories
{
    public class UsersRepository :Repository<User>, IUsersRepository
    { 
        public UsersRepository(ApplicationDbContext context): base(context) {      
            
        }
         
        public User GetUserWithRoles(int Id)
        {
          return _context.Users.Include(u => u.Roles).FirstOrDefault(u => u.Id == Id);
        }
        
        
    }
}
