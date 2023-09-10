using System.ComponentModel.DataAnnotations.Schema;

namespace Examination.Models.Database
{
    public class Question
    {
        public int Id { get; set; }

        public string Text { get; set; } = string.Empty;

        public int ExamId { get; set; }

        [ForeignKey(nameof(ExamId))]
        public Exam Exam { get; set; }

        public List<Answer> Answers { get; set; } = new();
    }
}