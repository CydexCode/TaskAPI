using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using TaskAPI.Models;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTodos()
        {
            var mytodos = AllTodos();
            return Ok(mytodos);
        }

        //Get Todos
        private List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Test Title 01",
                Description = "Test Description 01",
                CreatedDate = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };
            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "Test Title 01",
                Description = "Test Description 01",
                CreatedDate = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };

            todos.Add(todo2);

            var todo3 = new Todo
            {
                Id = 3,
                Title = "Test Title 01",
                Description = "Test Description 01",
                CreatedDate = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };
            todos.Add(todo3);

            return todos;

        }
    }
}
