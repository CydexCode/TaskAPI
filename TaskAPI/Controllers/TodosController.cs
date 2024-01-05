using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using System.Linq;
using TaskAPI.Services.Todos;

namespace TaskAPI.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {

        private readonly ITodoRepository _todoServices;

        public TodosController(ITodoRepository repository)
        {
            _todoServices = repository;
        }

        [HttpGet]
        public IActionResult GetTodos()
        {
            var mytodos = _todoServices.AllTodos();

            return Ok(mytodos);
        }

        [HttpGet("{id}")]
        public IActionResult GetTodo(int id)
        {
            var todo = _todoServices.GetTodo(id);

            if (todo is null) 
            {
                return NotFound();
            }

            return Ok(todo);
        }

       

        
    }
}
