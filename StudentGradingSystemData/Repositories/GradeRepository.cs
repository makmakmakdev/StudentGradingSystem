using Dapper;
using Microsoft.Extensions.Configuration;
using StudentGradingSystemData.DataAccess;
using StudentGradingSystemData.Dtos;
using StudentGradingSystemData.Models;

namespace StudentGradingSystemData.Repositories
{
    public class GradeRepository : IGradeRepository
    {
        private readonly IDataAccess _db;

        public GradeRepository(IConfiguration config)
        {
            _db = new DataAccess.DataAccess(config);
        }

        public async Task Add(GradeModel grade)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("Subject", grade.Subject);
            parameters.Add("Score", grade.Score);
            parameters.Add("StudentId", grade.StudentId);

            await _db.Execute("sp_AddGrade", parameters);
        }

        public async Task<IEnumerable<GetAllGradeDto>> GetAll()
        {
            return await _db.Query<GetAllGradeDto>("sp_GetAllGrade", null);
        }
    }
}
