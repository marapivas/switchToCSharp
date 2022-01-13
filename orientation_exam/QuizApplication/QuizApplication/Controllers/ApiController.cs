using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizApplication.Services;

namespace QuizApplication.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private QuestionService QuestionService { get; set; }

        public ApiController(QuestionService questionService)
        {
            QuestionService = questionService;
        }
        [HttpGet("question")]
        public IActionResult GetAllQuestion()
        {
            var questionList = QuestionService.GetAllQuestion();

            return Ok(questionList);
        }
    }
}
