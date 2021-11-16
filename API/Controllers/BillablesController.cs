using Persistence;
using System.Threading.Tasks;
using System.Collections.Generic;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;
using Application.BillablesCRUD;
using MediatR;

namespace API.Controllers
{
    public class BillablesController : BaseApiController
    {

        [HttpGet]
        public async Task<ActionResult<List<Billables>>> GetBillables()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Billables>> GetBillables(Guid id)
        {
            return await Mediator.Send(new Details.Query{Id = id});
        }

        [HttpPost]
        public async Task<IActionResult> CreateBillable(Billables billables)
        {
            return Ok(await Mediator.Send(new Create.Command {Billables = billables}));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditBillable(Guid id, Billables billables)
        {
            billables.Id = id;
            return Ok(await Mediator.Send(new Edit.Command{Billables = billables}));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCrew(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command{Id = id}));
        }

    }
}