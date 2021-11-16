using Persistence;
using System.Threading.Tasks;
using System.Collections.Generic;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using MediatR;
using Application.PunchesCRUD;

namespace API.Controllers
{
    public class PunchController : BaseApiController
    {

        [HttpGet]
        public async Task<ActionResult<List<Punch>>> GetPunches()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")] 
        public async Task<ActionResult<Punch>> GetPunch(Guid id)
        {
            return await Mediator.Send(new Details.Query{Id = id});
        }

        [HttpPost]
        public async Task<IActionResult> CreatePunch (Punch punch)
        {
            return Ok(await Mediator.Send(new Create.Command {Punch = punch}));
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> EditPunch(Guid id, Punch punch)
        {
            punch.Id = id;
            return Ok(await Mediator.Send(new Edit.Command{Punch = punch}));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJob(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command{Id = id}));
        }
    }
}