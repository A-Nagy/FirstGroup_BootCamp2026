using FirstGroup_1.Models;
using FirstGroup_1.Repositories.Base;
using System.Xml.Serialization;

namespace FirstGroup_1.Repositories.Users
{
    public interface IUsersRepository : IRepository<User>
    {
       User GetUserWithRoles(int Id);




    }
}
