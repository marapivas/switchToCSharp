using System.Collections.Generic;
using Workshop2.Database;
using System;
using System.Linq;
using Workshop2.Models;

namespace Workshop2.Services
{
    public class AssigneeService
    {

        private ApplicationDbContext DbContext { get; set; }

        public AssigneeService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;

        }
        public List<Assignee> GetAssignees()
        {
            return DbContext.Assignees.ToList();
        }

        internal void DeleteAssignee(int id)
        {
            DbContext.Remove(DbContext.Assignees.Where(a => a.Id == id).FirstOrDefault());
            DbContext.SaveChanges();
        }

        public void Add(string name, string email)
        {
            Assignee newAssignee = new Assignee();
            newAssignee.Name = name;
            newAssignee.Email = email;
            DbContext.Assignees.Add(newAssignee);
            DbContext.SaveChanges();

        }

        public void Edit(int id, string name)
        {

            Assignee editAssignee = DbContext.Assignees.Where(a => a.Id == id).First();
 
                editAssignee.Name = name;
            
            DbContext.Assignees.Update(editAssignee);
            DbContext.SaveChanges();

        }
        public List<Assignee> FindBySearchstring(string input)
        {
            var result = DbContext.Assignees.Where(a => a.Email.Contains(input) || a.Name.Contains(input)).ToList();

            return result;
        }

        public Assignee FindById(int id)
        {
            return GetAssignees().Where(a => a.Id == id).FirstOrDefault();
        }
    }
}
