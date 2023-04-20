using Domain.Models;
using Microsoft.Extensions.Configuration;

namespace DataAccessSql.Repositories
{
    public class AuthenticationRepository : BaseRepository, IAuthenticationRepository
    {
        public AuthenticationRepository(IConfiguration configuration) : base(configuration.GetConnectionString("Db_Todo_List")) { }

        public async Task RegisterUser(UserRegisterModel userRegister)
        {
            var parameters = new
            {
                FirstName = userRegister.FirstName,
                LastName = userRegister.LastName,
                UserName = userRegister.Username,
                Email = userRegister.Email,
                Password = userRegister.Password,
                CreateDate = DateTime.Now
            };

            var query = @"INSERT INTO Users (FirstName, LastName, UserName, Email, Password, CreateDate)
                        VALUES 
                        (@FirstName, @LastName, @UserName, @Email, @Password, @CreateDate)";

            await ExecuteAsync(query, parameters, commandType: System.Data.CommandType.Text);
        }
    }
}
