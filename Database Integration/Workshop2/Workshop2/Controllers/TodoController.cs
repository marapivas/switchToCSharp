using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Workshop2.Database;
using Workshop2.Models;
using Workshop2.Services;

namespace Workshop2.Controllers
{

    [Route("todo")]
    public class TodoController : Controller
    {

        private TodoService todoService { get; set; }
        private AssigneeService assigneeService { get; set; }

        public TodoController(TodoService todoService, AssigneeService  assigneeService)
        {
            this.todoService = todoService;
            this.assigneeService = assigneeService;
        }        

        [HttpGet("")]
        [HttpGet("list")]
        public IActionResult List([FromQuery] bool? isActive)
        {
           
            if(isActive.HasValue)
            {
                if(isActive.Value == false)
                {
                    var todo = new TodoViewModel() { AllTodos = todoService.FindFinished() };
                    return View(todo);
                }
                else 
                {
                    var todo = new TodoViewModel() { AllTodos = todoService.FindActive() };
                    return View(todo);
                }
            }
            else
            {
                var todo = new TodoViewModel() { AllTodos = todoService.GetTodos() };
                return View(todo);
            }            
        }

        [HttpGet("add")]
        public IActionResult AddTodo()
        {
            return View("AddTodo");
        }

        [HttpPost("add")]
        public IActionResult AddTodo([FromForm] string title)
        {
            todoService.AddTodo(title);

            return RedirectToAction("list");

        }

        [HttpGet("{id}/delete")]
        public IActionResult DeleteTodo([FromRoute] int id)
        {
            todoService.DeleteTodo(id);

            return RedirectToAction("list");
        }

        [HttpGet("{id}/edit")]
        public IActionResult EditTodo([FromRoute] int id)
        {

            var todo = new TodoViewModel()
            {
                Todo = todoService.FindById(id), AllAssignees = assigneeService.GetAssignees()
            };

            return View("EditTodo", todo);
        }

        [HttpPost("{id}/edit")]
        public IActionResult EditTodo([FromRoute] int id,[FromForm] Todo todo, [FromForm] bool urgent, [FromForm] bool done)
        {
            todoService.EditTodo(id, todo, urgent, done);

            return RedirectToAction("list");
        }

        [HttpPost("search")]
        public IActionResult Search([FromForm] string input)
        {
            if(input.Any())
            {
                var todo = new TodoViewModel() { AllTodos = todoService.FindBySearchstring(input) };

                return View("list", todo);
            }

            return RedirectToAction("list");
        }
    }
}
