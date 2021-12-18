﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Controllers
{
    public class AdminController : Controller
    {
        [Authorize(Roles ="admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
