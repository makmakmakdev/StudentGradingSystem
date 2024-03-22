using StudentGradingSystemData.Models;

namespace StudentGradingSystemData.Services
{
    public interface IGradeCalculator
    {
        double CalculateGradeAverage(List<GradeModel> grades);
    }
}
