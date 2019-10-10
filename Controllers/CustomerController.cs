using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApiExample.Controllers
{
    [ApiController] 
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public Object Read(){
            var data = new { Id= 1, FirstName= "SUO", LastName= "SUO", Email= "suosuo@gmail.com" };
            return data;
        }

        [HttpPost]
        public string Create(){
            return "simon";
        }

        [HttpPut]
        public string Update(){
            return "simonatoña";
        }

        [HttpDelete]
        public string Delete(){
            return "BYEBYE";
        }
    }
}

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;

// namespace WebApiExample.Controllers
// {
//     [ApiController]
//     [Route("api/[controller]")]
//     public class CustomerController: ControllerBase
//     {
//         [HttpGet]
//         public Object Read()
//         {
//             var data =new {Id=1, FirstName="Steve", LastName="Bishop", Email="steve.bishop@galvanize.com"};
//             return data;
//         }
//         [HttpPost]
//         public string Create()
//         {
//             return "Created";
//         }
//          [HttpPut]
//         public string Update()
//         {
//             return "Updated";
//         }
//         [HttpDelete]
//         public string Delete()
//         {
//             return "Deleted";
//         }
//     }
    
// }