namespace Examination.Models.Database
{
    public class Result
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int ExamId { get; set; }

        public int Score { get; set; }
    }
}