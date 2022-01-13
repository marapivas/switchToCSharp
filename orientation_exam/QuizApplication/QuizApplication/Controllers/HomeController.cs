using Microsoft.AspNetCore.Mvc;
using QuizApplication.Models;
using QuizApplication.Services;

namespace QuizApplication.Controllers
{
    public class HomeController : Controller
    {
        private QuestionService QuestionService { get; set; }

        public HomeController(QuestionService questionService)
        {
            QuestionService = questionService;
        }

        [HttpGet("")]
        [HttpGet("home")]
        public IActionResult Home()
        {
            var questionList = QuestionService.GetAllQuestion();

            return View("Index", questionList);
        }

        [HttpGet("question")]
        public IActionResult AddQuestionForm()
        {
            return View("Addquestion");
        }

        [HttpPost("question")]
        public IActionResult AddQuestion(   [FromForm] string question, 
                                            [FromForm] string answer1,
                                            [FromForm] string answer2,
                                            [FromForm] string answer3,
                                            [FromForm] string answer4,
                                            [FromForm] int correct)
        {
            QuestionService.AddQuestion(question, answer1, answer2, answer3, answer4, correct);

            return RedirectToAction("Index");

        }

        [HttpGet("quiz")]
        public IActionResult GetQuizz([FromRoute] int id, [FromRoute] int answer)
        {
            return View();
        }
    }
}
