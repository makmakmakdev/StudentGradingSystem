using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradingSystemData.DataAccess
{
    public class DataAccess : IDataAccess
    {
        private readonly string _connectionString;

        public DataAccess(IConfiguration config)
        {
            _connectionString = config["ConnectionStrings:Default"] ?? "";
        }

        public async Task Execute(string query, DynamicParameters param)
        {
            try
            {
                using IDbConnection connection = new SqlConnection(_connectionString);

                await connection.ExecuteAsync(query, param);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task<IEnumerable<T>> Query<T>(string query, DynamicParameters param)
        {
            try
            {
                using IDbConnection connection = new SqlConnection(_connectionString);

                return await connection.QueryAsync<T>(query, param);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Enumerable.Empty<T>();
            }
        }

        public async Task<T> QueryFirstOrDefault<T>(string query, DynamicParameters param)
        {
            try
            {
                using IDbConnection connection = new SqlConnection(_connectionString);

                return await connection.QueryFirstOrDefaultAsync<T>(query, param);
            }
            catch (Exception ex)
            {
                Console.WriteLine("QueryFirstOrDefault: " + ex.Message);

                return default;
            }
        }
    }
}
