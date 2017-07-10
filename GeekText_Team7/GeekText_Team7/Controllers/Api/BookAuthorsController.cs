using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GeekText_Team7.Models;
using Microsoft.Extensions.Logging;
using GeekText_Team7.ViewModels;
using AutoMapper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GeekText_Team7.Controllers.Api
{
    [Route("api/bookauthors")]
    public class BookAuthorsController : Controller
    {
        private IBookStoreRepository _repository;
        private ILogger<BooksController> _logger;

        public BookAuthorsController(IBookStoreRepository repository, ILogger<BooksController> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        // GET: api/values
        [HttpGet("")]
        public IActionResult Get()
        {
            try
            {
                var results = _repository.GetBookAuthors();

                return Ok(Mapper.Map<IEnumerable<BookAuthorViewModel>>(results));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get All Book/Authors: {ex}");

                return BadRequest("Error occurred");
            }
        }

        // GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
