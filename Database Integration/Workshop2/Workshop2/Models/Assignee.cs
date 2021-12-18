using System.Collections.Generic;

namespace Workshop2.Models
{
    public class Assignee
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public string Email { get; set;}

        public List<Todo> AssigneesTodo { get; set; }
    }
}
