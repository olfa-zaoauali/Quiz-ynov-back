using Microsoft.AspNetCore.Mvc;
using quiz_ynov.Business.Models;
using quiz_ynov.Business;
using quiz_ynov.Controllers.Dtos;
using quiz_ynov.Controllers.Mappers;

namespace quiz_ynov.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _Service;
        private readonly QuestionMapper _Mapper;

        public QuestionController(IQuestionService service, QuestionMapper mapper)
        {
            _Service = service;
            _Mapper = mapper;
        }

        [HttpGet(Name = "GetAllQuestion")]
        [ProducesResponseType(typeof(IEnumerable<QuestionDto>), 200)]
        public IActionResult GetAll()
        {
            IEnumerable<QuestionDto> dtos = _Service.GetAll().Select(question => _Mapper.toDto(question));
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetQuestion")]
        [ProducesResponseType(typeof(QuestionDto), 200)]
        public IActionResult GetByID(Guid id)
        {
            Question question = _Service.GetById(id);
            QuestionDto dto = _Mapper.toDto(question);
            return Ok(dto);
        }


        [HttpPost("calculateScore")]
        [ProducesResponseType(typeof(int), 200)]
        [ProducesResponseType(400)]
        public IActionResult CalculScore([FromBody] List<ResponseDto> responses)
        {
            if (responses == null || responses.Count == 0)
            {
                return BadRequest("La liste des réponses est vide.");
            }

            try
            {
                int score = _Service.ScoreCalcul(responses);
                return Ok(score);
            }
            catch (Exception ex)
            {
                return BadRequest($"Une erreur est survenue lors du calcul du score: {ex.Message}");
            }
        }




    }
}
