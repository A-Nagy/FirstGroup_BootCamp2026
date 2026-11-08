

using FirstGroup_1.Domain;

namespace FirstGroup_1.Application.Abstractions.Repositories
{
    public interface IUsersRepository : IRepository<User>
    {
       User GetUserWithRoles(int Id);




    }
}
