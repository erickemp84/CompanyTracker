using Persistence;
using System.Threading.Tasks;
using System.Collections.Generic;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using MediatR;
using Application.CustomersCRUD;

namespace API.Controllers
{
    public class CustomerController : BaseApiController 
    {

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetCustomers()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomers(Guid id)
        {
            return await Mediator.Send(new Details.Query{Id = id});
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer(Customer customer)
        {
            return Ok(await Mediator.Send(new Create.Command {Customer = customer}));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditCustomer(Guid id, Customer customer)
        {
            customer.Id = id;
            return Ok(await Mediator.Send(new Edit.Command{Customer = customer}));
        }

    }
}