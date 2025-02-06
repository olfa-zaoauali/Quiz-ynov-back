using quiz_ynov.Business.Models;

namespace quiz_ynov.Business.Services
{
    public class CategoryService : ICategoryService
    {
        private List<Category> _categoryList = new List<Category>
    {
        new Category
        {
            Id = new Guid("7ea81c2e-458f-4def-9c6e-eee6365677bd"),
            Name = "Web Development"
        },
        new Category
        {
            Id = new Guid("a1d2e4f6-789a-4bcd-b9c1-f8d2355678de"),
            Name = "Programming Basics"
        },
        new Category
        {
    Id = new Guid("3f7b0f65-5e6d-4bb1-8a97-7c4c8f220e7f"),
            Name = "Artificial Intelligence"
        },
        new Category
{
    Id = new Guid("b2f3c4d5-67e8-4a9b-b0c2-d1e2345678ef"),
    Name = "Mobile Development"
}



    };

        public IEnumerable<Category> GetAll()
        {
            return _categoryList;
        }

        public Category GetById(Guid id)
        {
            return _categoryList.FirstOrDefault(category => category.Id == id);
        }
    }
}
