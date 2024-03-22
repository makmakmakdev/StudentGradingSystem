using Dapper;
using Microsoft.Extensions.Configuration;
using StudentGradingSystemData.DataAccess;
using StudentGradingSystemData.Dtos;
using StudentGradingSystemData.Models;
using static Dapper.SqlMapper;

namespace StudentGradingSystemData.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IDataAccess _db;

        public StudentRepository(IConfiguration config)
        {
            _db = new DataAccess.DataAccess(config);
        }

        public async Task Add(StudentModel student)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("Name", student.Name);

            await _db.Execute("sp_AddStudent", parameters);
        }

        public async Task<IEnumerable<StudentModel>> GetAll()
        {
            return await _db.Query<StudentModel>("sp_GetAllStudent", null);
        }

        public async Task<StudentModel> GetById(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("StudentId", id);

            return await _db.QueryFirstOrDefault<StudentModel>("sp_GetStudentById", parameters);
        }

        public async Task<IEnumerable<GetStudentWithGradesResponseDto>> GetGrades(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("StudentId", id);

            return await _db.Query<GetStudentWithGradesResponseDto>("sp_GetStudentWithGrades", parameters);
        }
    }
}
