using quiz_ynov.Business.Models;
using quiz_ynov.Controllers.Dtos;

namespace quiz_ynov.Controllers.Mappers
{
    public class QuizMapper
    {
        public QuizDto toDto(Quiz quiz)
        {
            return new QuizDto
            {
                Id = quiz.Id,
                Description = quiz.Description,
                Difficulty = quiz.Difficulty,
                Name = quiz.Name,
                DateCreation = quiz.DateCreation,
                CategoryById = quiz.Category.Id
            };

        }
           
    }
}
