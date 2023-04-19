using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessSql.Repositories
{
    public abstract class BaseRepository
    {
        protected string ConnectionString { get; }

        protected BaseRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected async Task<IEnumerable<T>> QueryAsync<T>(string query, object param = null, CommandType? commandType = null)
        {
            using IDbConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            return await conn.QueryAsync<T>(query, param, commandType: commandType);
        }

        protected async Task<T> QueryFirstOrDefaultAsync<T>(string query, object param = null, CommandType? commandType = null)
        {
            using IDbConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            return await conn.QueryFirstOrDefaultAsync<T>(query, param, commandType: commandType);
        }

        protected async Task<int> ExecuteAsync(string query, object param = null, CommandType? commandType = null)
        {
            using IDbConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            return await conn.ExecuteAsync(query, param, commandType: commandType);
        }
    }
}