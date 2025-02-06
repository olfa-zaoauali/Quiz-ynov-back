using quiz_ynov.Business.Models;
using quiz_ynov.Controllers.Dtos;

namespace quiz_ynov.Controllers.Mappers
{
    public class CategoryMapper
    {
        public CategoryDto toDto(Category category)
        {
            return new CategoryDto
            {
                Id = category.Id,
                Name = category.Name
            };
        }
    }
}
