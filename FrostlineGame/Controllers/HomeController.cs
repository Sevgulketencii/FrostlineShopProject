﻿using FrostlineGame.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FrostlineGame.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
