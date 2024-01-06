using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
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
            var authors = _service.GetAllAuthors();
            var authorsDto = new List<AuthorDto>();

            foreach (var author in authors)
            {
                authorsDto.Add(new AuthorDto
                    {
                    Id = author.Id,
                    FullName = author.FullName,
                        Address = $"{author.AddressNo}, {author.Street} , {author.City}"
                });
            }

            return Ok(authorsDto);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id)
        {
            var author = _service.GetAuthor(id);

            if(author is null)
            {
                return NotFound();
            }

            return Ok(author);
        }

    }
}
