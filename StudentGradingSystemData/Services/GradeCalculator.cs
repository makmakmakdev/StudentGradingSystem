using StudentGradingSystemData.Models;

namespace StudentGradingSystemData.Services
{
    public class GradeCalculator : IGradeCalculator
    {
        public double CalculateGradeAverage(List<GradeModel> grades)
        {
            var scores = grades.Select(g => g.Score).ToList();

            return scores.Count == 0 ? 0 : scores.Average();
        }
    }
}
