using StudentGradingSystemData.Dtos;
using StudentGradingSystemData.Models;

namespace StudentGradingSystemData.Repositories
{
    public interface IGradeRepository
    {
        Task Add (GradeModel grade);
        Task<IEnumerable<GetAllGradeDto>> GetAll();
    }
}
