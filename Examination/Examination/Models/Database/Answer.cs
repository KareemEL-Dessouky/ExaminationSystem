using System.ComponentModel.DataAnnotations.Schema;

namespace Examination.Models.Database
{
    public class Answer
    {
        public int Id { get; set; }

        public string Text { get; set; } = string.Empty;

        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }

        [ForeignKey(nameof(QuestionId))]
        public Question Question { get; set; }
    }
}