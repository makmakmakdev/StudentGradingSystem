using StudentGradingSystemData.Dtos;
using StudentGradingSystemData.Models;

namespace StudentGradingSystemData.Repositories
{
    public interface IStudentRepository
    {
        Task<StudentModel> GetById(int id);
        Task<IEnumerable<StudentModel>> GetAll();
        Task Add(StudentModel student);
        Task<IEnumerable<GetStudentWithGradesResponseDto>> GetGrades(int id);
    }
}
