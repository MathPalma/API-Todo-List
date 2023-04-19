using Microsoft.Extensions.Configuration;

namespace DataAccessSql.Repositories
{
    public class AuthenticationRepository : BaseRepository, IAuthenticationRepository
    {
        public AuthenticationRepository(IConfiguration configuration) : base(configuration.GetConnectionString("Db_Todo_List")) { }

        public async Task RegisterUser()
        {
            await Console.Out.WriteLineAsync("a");
        }
    }
}
