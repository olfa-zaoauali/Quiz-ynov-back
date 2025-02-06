using quiz_ynov.Business.Models;

namespace quiz_ynov.Business
{
    public interface IQuizService
    {
        IEnumerable<Quiz> GetAll();
        public Quiz GetById(Guid id);
        int ScroreCalcul(Quiz quiz);

        // Ajouter un nouveau quiz
        // Quiz Create(Quiz quiz);

        // Mettre à jour un quiz existant
        //Quiz Update(Guid id, Quiz quiz);

        // Supprimer un quiz par son identifiant
        //void Delete(Guid id);

    }
}
