namespace StudentGradingSystemData.Models
{
    public class GradeModel
    {
        public  int  Id { get; set; }
        public string Subject { get; set; } = string.Empty;
        public double Score { get; set; }
        public int StudentId { get; set; }
    }
}