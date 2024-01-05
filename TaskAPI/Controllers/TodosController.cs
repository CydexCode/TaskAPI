using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using TaskAPI.Services;
using System.Linq;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {

        private readonly ITodoRepository _todoServices;

        public TodosController(ITodoRepository repository)
        {
            _todoServices = repository;
        }

        [HttpGet("{id?}")]
        public IActionResult GetTodos(int? id)
        {
            var mytodos = _todoServices.AllTodos();

            if (id is null) return Ok(mytodos);

            mytodos = mytodos.Where(t => t.Id == id).ToList();

            return Ok(mytodos);
        }

       

        
    }
}
