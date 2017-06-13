﻿using System;
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
    [Route("api/users")]
    public class UsersController : Controller
    {
        private IBookStoreRepository _repository;
        private ILogger<UsersController> _logger;

        public UsersController(IBookStoreRepository repository, ILogger<UsersController> logger)
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
                var results = _repository.GetAllUsers();

                return Ok(Mapper.Map<IEnumerable<UserViewModel>>(results));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get All Users: {ex}");

                return BadRequest("Error occurred");
            }
        }

        //// GET api/values/5
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