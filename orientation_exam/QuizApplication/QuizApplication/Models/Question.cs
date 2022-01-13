using System.Text.Json.Serialization;

namespace QuizApplication.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Quest { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        [JsonIgnore]
        public int Correct { get; set; }
        public int Point { get; set; }
    }
}
