using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using TaskAPI.Models;
using TaskAPI.Services;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {

        private TodoService _todoServices;

        public TodosController()
        {
            _todoServices = new TodoService();
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
