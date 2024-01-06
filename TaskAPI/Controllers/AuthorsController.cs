using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using TaskAPI.Models;
using TaskAPI.Services.Authors;
using TaskAPI.Services.Models;

namespace TaskAPI.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _service;
        private readonly IMapper _mapper;
        public AuthorsController(IAuthorRepository service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<Collection<AuthorDto>> GetAuthors()
        {
            throw new Exception("Test Eroor");
            var authors = _service.GetAllAuthors();
            var authorsDto = new List<AuthorDto>();

         var mappedAuthors = _mapper.Map<ICollection<AuthorDto>>(authors);

            return Ok(mappedAuthors);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id)
        {
            var author = _service.GetAuthor(id);

            if(author is null)
            {
                return NotFound();
            }

            var mappedAuthor = _mapper.Map<AuthorDto>(author);


            return Ok(mappedAuthor);
        }

    }
}
