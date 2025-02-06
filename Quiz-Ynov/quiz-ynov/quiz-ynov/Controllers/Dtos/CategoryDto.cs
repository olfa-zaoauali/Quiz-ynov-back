using quiz_ynov.Business.Models;

namespace quiz_ynov.Controllers.Dtos
{
    public class CategoryDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        // une catégorie contient plusieurs quiz, donc cette propriété n'est pas nécessaire ici.


    }
}
