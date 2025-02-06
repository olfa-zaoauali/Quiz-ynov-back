using Microsoft.AspNetCore.Mvc;
using quiz_ynov.Business;
using quiz_ynov.Business.Models;
using quiz_ynov.Controllers.Dtos;
using quiz_ynov.Controllers.Mappers;

namespace quiz_ynov.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _Service;
        private readonly CategoryMapper _Mapper;
        public CategoryController(ICategoryService service, CategoryMapper mapper)
        {
            _Service = service;
            _Mapper = mapper;
        }
        [HttpGet(Name = "GetAllCategory")]
        [ProducesResponseType(typeof(IEnumerable<CategoryDto>), 200)]
        public IActionResult GetAll()
        {
            IEnumerable<Category> dtos = _Service.GetAll();
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetCategory")]
        [ProducesResponseType(typeof(CategoryDto), 200)]
        public IActionResult GetByID(Guid id)
        {
            Category category = _Service.GetById(id);
            CategoryDto dto = _Mapper.toDto(category);
            return Ok(dto);
        }
    }
}
