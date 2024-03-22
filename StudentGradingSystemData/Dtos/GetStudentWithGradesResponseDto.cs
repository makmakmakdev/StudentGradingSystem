using StudentGradingSystemData.Models;

namespace StudentGradingSystemData.Dtos
{
    public class GetStudentWithGradesResponseDto : StudentModel
    {
        public string Subject { get; set; } = string.Empty;
        public double Score { get; set; }
    }
}
