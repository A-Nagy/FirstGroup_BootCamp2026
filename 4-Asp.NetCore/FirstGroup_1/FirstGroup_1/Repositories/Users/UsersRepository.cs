using FirstGroup_1.Data;
using FirstGroup_1.Models;
using FirstGroup_1.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace FirstGroup_1.Repositories.Users
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
