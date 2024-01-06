using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using System.Linq;
using TaskAPI.Services.Todos;
using AutoMapper;
using TaskAPI.Services.Models;
using System.Collections.ObjectModel;

namespace TaskAPI.Controllers
{
    [Route("api/authors/{authorId}/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {

        private readonly ITodoRepository _todoServices;
        private readonly IMapper _mapper;

        public TodosController(ITodoRepository repository,IMapper mapper)
        {
            _todoServices = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<Collection<TodoDto>> GetTodos(int authorId)
        {
            var mytodos = _todoServices.AllTodos(authorId);

            var mappedTodos = _mapper.Map<ICollection<TodoDto>>(mytodos);

            return Ok(mappedTodos);
        }

        [HttpGet("{id}")]
        public IActionResult GetTodo(int authorId, int id)
        {
            var todo = _todoServices.GetTodo(authorId, id);

            if (todo is null) 
            {
                return NotFound();
            }

            var mappedTodo = _mapper.Map<TodoDto>(todo);

            return Ok(mappedTodo);
        }

       

        
    }
}
