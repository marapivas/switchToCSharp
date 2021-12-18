using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Workshop2.Models;
using Workshop2.Services;

namespace Workshop2.Controllers
{
    [Route("assignee")]
    public class AssigneeController : Controller
    {
        private AssigneeService assigneeService { get; set; }
        private TodoService todoService { get; set; }

        public AssigneeController(AssigneeService assigneeService, TodoService todoService)
        {
            this.assigneeService = assigneeService;
            this.todoService = todoService;
        }

        [HttpGet("")]
        [HttpGet("list")]
        public IActionResult List()
        {
            var assignee = new AssigneeViewModel
            {
                AllAssignees = assigneeService.GetAssignees()
            };

            return View(assignee);
        }

        [HttpGet("{id}/delete")]
        public IActionResult DeleteAssignee([FromRoute] int id)
        {
            assigneeService.DeleteAssignee(id);

            return RedirectToAction("list");
        }

        [HttpGet("add")]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm] string name, [FromForm] string email)
        {

            assigneeService.Add(name, email);

            return RedirectToAction("List");
        }

        [HttpGet("{id}/edit")]
        public IActionResult Edit()
        {
            return View("Edit");
        }

        [HttpPost("{id}/edit")]
        public IActionResult Edit([FromRoute] int id, [FromForm] string name)
        {
            assigneeService.Edit(id, name);

            return RedirectToAction("List");
        }

        [HttpPost("search")]
        public IActionResult Search([FromForm] string input)
        {

            if (input.Any())
            {
                var assignee = new AssigneeViewModel() { AllAssignees = assigneeService.FindBySearchstring(input) };

                return View("list", assignee);
            }

            return RedirectToAction("list");
        }

        [HttpGet("{id}/show")]
        public IActionResult AssigneeTasks([FromRoute] int id)
        {

            var allTodos = new AssigneeViewModel()
            {
                Assignee = assigneeService.FindById(id),
                AllAssigneesTodos = todoService.FindAllByAssId(id)
            };

            return View("AllTask", allTodos);
        }
    }
}
