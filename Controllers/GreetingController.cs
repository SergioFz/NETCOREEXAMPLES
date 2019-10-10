using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApiExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingController: ControllerBase
    {
        [HttpGet("{username}/{reponame}")]
        public string Get(string username, string reponame)
        {
            return "Hello, it's me";
        }
    }
    
}