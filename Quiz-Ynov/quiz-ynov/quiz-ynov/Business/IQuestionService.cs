using quiz_ynov.Business.Models;
using quiz_ynov.Controllers.Dtos;

namespace quiz_ynov.Business
{
    public interface IQuestionService
    {
        // Récupérer toutes les questions
        IEnumerable<Question> GetAll();

        // Récupérer une question par son identifiant
        Question GetById(Guid id);
        int ScoreCalcul(List<ResponseDto> responses);

        // Ajouter une nouvelle question
        //Question Create(Question question);

        // Mettre à jour une question existante
        //Question Update(Guid id, Question question);

        // Supprimer une question par son identifiant
        //void Delete(Guid id);
    }
}
