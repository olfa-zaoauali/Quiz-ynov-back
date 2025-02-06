using quiz_ynov.Business.Models;
using quiz_ynov.Controllers.Dtos;

namespace quiz_ynov.Controllers.Mappers
{
    public class QuestionMapper
    {
        public QuestionDto toDto(Question question)
        {
            return new QuestionDto
            {
                Id = question.Id,
                Content = question.Content,
                QuizId = question.Quiz.Id,
                Choices = question.Choices,
                CorrectAnswer=question.CorrectAnswer,
            };
        }

    }
}
