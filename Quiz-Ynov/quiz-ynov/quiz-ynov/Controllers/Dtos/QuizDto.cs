using quiz_ynov.Business.Models;

namespace quiz_ynov.Controllers.Dtos
{
    public class QuizDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Difficulty { get; set; }
        public DateTime DateCreation { get; set; }

        public Guid CategoryById { get; set; }

    }
}
