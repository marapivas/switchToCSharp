using System;
using System.Collections.Generic;

namespace Workshop2.Models
{
    public class AssigneeViewModel
    {
        public Assignee Assignee { get; set; }

        public List<Assignee> AllAssignees { get; set; }
        public List<Todo> AllAssigneesTodos { get; set; }
    }
}
