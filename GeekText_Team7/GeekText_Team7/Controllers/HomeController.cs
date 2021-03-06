﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using GeekText_Team7.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using System.IO;
using GeekText_Team7.Data;

namespace GeekText_Team7.Controllers
{
    public class HomeController : Controller
    {

        private IConfigurationRoot _config;
        private ILogger<HomeController> _logger;

        public HomeController(IConfigurationRoot config, ILogger<HomeController> logger)
        {
            _config = config;
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

        public IActionResult Author()
        {
            return View();
        }

        public IActionResult BookAuthor()
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

        public IActionResult Biography()
        {
            ViewData["Message"] = "Your Biography page.";

            return View();
        }

    }
}
