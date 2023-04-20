using Domain.Models;

namespace DataAccessSql
{
    public interface IAuthenticationRepository
    {
        Task RegisterUser(UserRegisterModel userRegister);
    }
}
