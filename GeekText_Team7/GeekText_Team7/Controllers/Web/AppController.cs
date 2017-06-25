using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using GeekText_Team7.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace GeekText_Team7.Controllers.Web
{
    public class AppController : Controller
    {
        private IConfigurationRoot _config;
        private IBookStoreRepository _repository;
        private ILogger<AppController> _logger;

        public AppController(IConfigurationRoot config, IBookStoreRepository repository, ILogger<AppController> logger)
        {
            _config = config;
            _repository = repository;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Users()
        {
            return View();
        }

        public IActionResult Books()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
