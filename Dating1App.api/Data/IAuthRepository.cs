using System.Threading.Tasks;
using Dating1App.api.Modules;

namespace Dating1App.api.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user,string password);

         Task<User> Login(string username, string password);

         Task<bool> UserExist(string username);
    }
}