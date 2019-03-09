using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;
using WebApplication1.Services;

namespace API_Rest.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/{version:apiVersion}/[controller]")]
    public class BookController : ControllerBase
    {
        private IBookService _service;

        public BookController(IBookService bookService)
        {
            _service = bookService;
        }

        // GET: api/Book
        [HttpGet]
        public IActionResult Get()
        {
            List<Book> books =_service.ListAllBook();
            return Ok(books);
        }

        // GET: api/Book/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            return Ok(_service.FindById(id));
        }

        // POST: api/Book
        [HttpPost]
        public IActionResult Post([FromBody] Book value)
        {
            return Ok(_service.Create(value));
        }

        // PUT: api/Book/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.RemoveById(id);
        }
    }
}
