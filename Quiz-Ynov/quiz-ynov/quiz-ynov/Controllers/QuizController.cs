using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using quiz_ynov.Business;
using quiz_ynov.Business.Models;
using quiz_ynov.Business.Services;
using quiz_ynov.Controllers.Dtos;
using quiz_ynov.Controllers.Mappers;

namespace quiz_ynov.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly IQuizService _Service;
        private readonly QuizMapper    _Mapper;

        public QuizController(IQuizService service, QuizMapper mapper)
        {
            _Service = service;
            _Mapper = mapper;
        }

        [HttpGet(Name ="GetAllQuiz")]
        [ProducesResponseType(typeof(IEnumerable<QuizDto>), 200)]
        public IActionResult GetAll() {
            IEnumerable<QuizDto> dtos= _Service.GetAll().Select(quiz => _Mapper.toDto(quiz));
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetQuiz")]
        [ProducesResponseType(typeof(QuizDto), 200)]
        public IActionResult GetByID(Guid id)
        {
            Quiz quiz= _Service.GetById(id);
            QuizDto  dto= _Mapper.toDto(quiz);
            return Ok(dto); 
        }

        
    }
}
