using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace helloworld.Controllers
{
    [Route("api/hello")]
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("{name}")]
        public IActionResult World(string name)
        {
            return this.Ok($"Hello {name}!");
        }
    }
}