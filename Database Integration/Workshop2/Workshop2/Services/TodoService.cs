using System.Collections.Generic;
using Workshop2.Database;
using Workshop2.Models;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace Workshop2.Services
{
    public class TodoService
    {
        private ApplicationDbContext DbContext { get; set; }

        public TodoService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;

        }

        public List<Todo> GetTodos()
        {
            return DbContext.Todos.Include(x => x.Assignee).ToList();
        }

        public List<Todo> FindActive()
        {
            return DbContext.Todos.Where(t => t.IsDone == false).ToList();
        }

        public List<Todo> FindFinished()
        {
            return DbContext.Todos.Where(t => t.IsDone == true).ToList();
        }

        public void AddTodo(string title)
        {
            Todo newTodo = new Todo();
            newTodo.Title = title;
            newTodo.IsDone = false;
            newTodo.IsUrgent = false;
            DbContext.Todos.Add(newTodo);
            DbContext.SaveChanges();
           
        }

        public void DeleteTodo(int id)
        {
            DbContext.Remove(DbContext.Todos.Where(t => t.Id == id).FirstOrDefault());
            DbContext.SaveChanges();
        }

        public void EditTodo(int id, Todo todo, bool urgent, bool done)
        {
            Todo editTodo = DbContext.Todos.Where(t => t.Id == id).First();
            editTodo.Id = id;
            editTodo.Description = todo.Description;
            editTodo.AssigneeId = todo.AssigneeId;
            editTodo.IsDone = done;          
            editTodo.IsUrgent = urgent;
            DbContext.Todos.Update(editTodo);
            DbContext.SaveChanges();
        }

        public List<Todo> FindBySearchstring (string input)
        {
            var result = DbContext.Todos.Where(t => t.Description.Contains(input) || t.Title.Contains(input)).ToList();
            
            return result;
        }

        public Todo FindById(int id)
        {
            var todo = GetTodos().Where(t => t.Id == id).FirstOrDefault();
            return todo;
        }

        public List<Todo> FindAllByAssId(int assigneeId)
        {
            var result = DbContext.Todos.Where(t => t.AssigneeId == assigneeId).ToList();

            return result;
        }
    }    
}
