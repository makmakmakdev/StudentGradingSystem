using StudentGradingSystemData.Models;

namespace StudentGradingSystemData.Dtos
{
    public class GetAllGradeDto : GradeModel
    {
        public string StudentName { get; set; } = string.Empty;
    }
}
