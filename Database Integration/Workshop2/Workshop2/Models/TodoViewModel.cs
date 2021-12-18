using System.Collections.Generic;

namespace Workshop2.Models
{
    public class TodoViewModel
    {
        public Todo Todo { get; set; }
        public List<Todo> AllTodos { get; set; }

        public Assignee Assignee { get; set; }
        public List<Assignee> AllAssignees { get; set; }

    }
}
