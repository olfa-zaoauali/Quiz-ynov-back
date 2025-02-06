using quiz_ynov.Business.Models;

namespace quiz_ynov.Business
{
    public interface ICategoryService
    {
        // Récupérer toutes les catégories
        IEnumerable<Category> GetAll();

        // Récupérer une catégorie par son identifiant
        Category GetById(Guid id);

        // Ajouter une nouvelle catégorie
        //Category Create(Category category);

        // Mettre à jour une catégorie existante
        //Category Update(Guid id, Category category);

        // Supprimer une catégorie par son identifiant
        //void Delete(Guid id);
    }
}
