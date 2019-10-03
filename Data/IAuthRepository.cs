using System.Threading.Tasks;
using Coupon.Api.Models;

namespace Coupon.Api.Data
{
    public interface IAuthRepository
    {
         Task<User> Register (User  user, string password);
         Task<User> Login (string username, string password);
         Task<bool> UserExists(string username);
    }
}