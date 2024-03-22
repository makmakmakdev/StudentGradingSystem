using Dapper;

namespace StudentGradingSystemData.DataAccess
{
    public interface IDataAccess
    {
        Task<IEnumerable<T>> Query<T>(string query, DynamicParameters param);
        Task<T> QueryFirstOrDefault<T>(string query, DynamicParameters param);
        Task Execute(string query, DynamicParameters param);
    }
}
