namespace Examination.Models.Database
{
    public class Exam
    {
        public int Id { get; set; }

        public string Subject { get; set; } = string.Empty;

        public List<Question> Questions { get; set; } = new();
    }
}