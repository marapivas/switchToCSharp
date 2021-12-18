using System;

namespace Workshop2.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsDone { get; set; }

        public int AssigneeId { get; set; }
        public Assignee Assignee { get; set; }
    }

}
