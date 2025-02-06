using quiz_ynov.Business.Models;

namespace quiz_ynov.Controllers.Dtos
{
    public class QuestionDto
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public Guid QuizId { get; set; }
        public IEnumerable<string> Choices { get; set; }
        public string CorrectAnswer { get; set; }

    }
}
