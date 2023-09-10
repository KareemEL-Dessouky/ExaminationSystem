using Examination.Models.Database;

namespace Examination.ViewModels
{
    public class ExamViewModel
    {
        public string Subject { get; set; } = string.Empty;

        public List<Question> Questions { get; set; } = new();

    }
}
