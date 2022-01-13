using QuizApplication.Database;
using QuizApplication.Models;
using System.Collections.Generic;
using System.Linq;

namespace QuizApplication.Services
{
    public class QuestionService
    {
        private ApplicationDbContext DbContext { get; set; }

        public QuestionService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public QuestionViewModel GetAllQuestion()
        {
            QuestionViewModel questionViewModel = new QuestionViewModel()
            {
                Questions = DbContext.Questions.ToList()
            };          

            return questionViewModel;
            
        }

        public void AddQuestion(string question, string answer1, string answer2, string answer3, string answer4, int correct)
        {
            Question newquestion = new Question();
            newquestion.Quest = question;
            newquestion.Answer1 = answer1;
            newquestion.Answer2 = answer2;
            newquestion.Answer3 = answer3;
            newquestion.Answer4 = answer4;
            newquestion.Correct = correct;

            DbContext.Questions.Add(newquestion);
            DbContext.SaveChanges();

        }
    }
}
