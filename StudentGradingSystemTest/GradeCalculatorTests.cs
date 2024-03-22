using StudentGradingSystemData.Models;
using StudentGradingSystemData.Services;

namespace StudentGradingSystemTest
{
    public class GradeCalculatorTests
    {
        private IGradeCalculator _gradeCalculator;

        [SetUp] public void Setup()
        {
            _gradeCalculator = new GradeCalculator();
        }

        [Test] 
        public void CalculateGradeAverage_WhenGradesListIsEmpty_ReturnsZero()
        {
            // Assign
            var grades = new List<GradeModel>();

            // Act
            var average = _gradeCalculator.CalculateGradeAverage(grades);

            // Assert
            Assert.That(average, Is.EqualTo(0));
        }

        [Test]
        public void CalculateGradeAverage_WhenGradesListIsNotEmpty_ReturnsCorrectAverage()
        {
            // Assign
            var grades = new List<GradeModel>
            {
                new GradeModel { Score = 91 },
                new GradeModel { Score = 92 },
                new GradeModel { Score = 93 },
            };

            // Act
            var average = _gradeCalculator.CalculateGradeAverage(grades);

            // Assert
            Assert.That(average, Is.EqualTo(92));
        }
    }
}
