using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using WebApiExample.Models;

namespace WebApiExample.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CustomerController : ControllerBase
    {

        private List<Customer> customers ;
        private List<CustomerPost> customerPost ;

        public CustomerController(){
            this.customers = new List<Customer>{
            new Customer { Id= 1, FirstName= "SUO", LastName= "SUO", Email= "suosuo@gmail.com" },
            new Customer { Id= 2, FirstName= "SUO1", LastName= "SUO", Email= "suosuo@gmail.com" },
            new Customer { Id= 3, FirstName= "SUO12", LastName= "SUO", Email= "suosuo@gmail.com" },
            new Customer { Id= 4, FirstName= "SUO123", LastName= "SUO", Email= "suosuo@gmail.com" },
            new Customer { Id= 5, FirstName= "SUO1234", LastName= "SUO", Email= "suosuo@gmail.com" }
            };

            this.customerPost = new List<CustomerPost>{
                new CustomerPost {Id= 1, FirstName= "sew", LastName= "uqwuqw", Email= "asjasdkasd@jasdjasdj.com" }
            };
        }


        //[HttpGet("api/customer/{id}")]
        [HttpGet("{id}")]
        [Produces("application/json")]
        public IActionResult GetOne([FromRoute] long id){

            foreach (Customer customer in this.customers){
                if (customer.Id == id){
                    return base.Ok(customer);
                }
            }
            //base.NotFound()
            return new NotFoundObjectResult("Could not find resource");
        }

        //[HttpGet("api/customer/")]
        [HttpGet]
        public IActionResult GetAll(){
            return Ok(this.customers);
        }


        //[HttpPost("api/customer")]
        [HttpPost]
        public IActionResult Create([FromBody] Customer newCustomer){
            // CustomerPost newCustomerPost = new CustomerPost{
            //     Id= this.customerPost.Count + 1,
            //     FirstName="John",
            //     LastName="Sonmez",
            //     Email="IdonotKnow@email.com"
            // };

            newCustomer.Id = customers.Count + 1;
            if(ModelState.IsValid)
            {
            this.customers.Add(newCustomer);
            foreach(Customer customer in this.customers){
                if(customer.Id == newCustomer.Id){
                    return CreatedAtAction("GetOne", new { customer = 1 });
                }
            }
            return base.StatusCode(500, new { errorMessage = "no store value jk"});
        }
        else{
            return base.ValidationProblem();
        }
            // this.customerPost.Add(newCustomerPost);
            // return "Created";
        }

        //[HttpPut("api/customer/{id}")]
        [HttpPut("{id}")]
        [Consumes("application/json")]
        
        public IActionResult Update([FromRoute] long id, [FromBody] Customer updatedCustomer){
            foreach(Customer customer in customers){
                if (customer.Id == id) {
                    customer.FirstName = updatedCustomer.FirstName;
                    customer.LastName = updatedCustomer.LastName;
                    customer.Email = updatedCustomer.Email;
                }
            }


            return NoContent();
        }

        //[HttpDelete("api/customer/{id}")]
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] long id){
            foreach(Customer customer in customers) {
                if (customer.Id == id){
                    customers.Remove(customer);
                    return StatusCode(410);
                }
            }
            return NotFound();
        }
    }
}