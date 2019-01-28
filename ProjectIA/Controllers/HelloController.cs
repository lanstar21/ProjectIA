using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjectIA.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Content("<h1>Hello World</h1>", "text/html");
        }

        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}
