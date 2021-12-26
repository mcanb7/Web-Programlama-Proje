using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kutuphane2.Controllers
{
    public class KitapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
