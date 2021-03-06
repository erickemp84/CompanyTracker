using Persistence;
using System.Threading.Tasks;
using System.Collections.Generic;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Application.CrewsCRUD;
using System;
using MediatR;

namespace API.Controllers
{
    public class CrewController : BaseApiController
    {
    
        [HttpGet]
        public async Task<ActionResult<List<Crews>>> GetCrews()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Crews>> GetCrews(Guid id)
        {
            return await Mediator.Send(new Details.Query{Id = id});
        }

        [HttpPost]
        public async Task<IActionResult> CreateCrew(Crews crews)
        {
            return Ok(await Mediator.Send(new Create.Command {Crews = crews}));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditCrew(Guid id, Crews crews)
        {
            crews.Id = id;
            return Ok(await Mediator.Send(new Edit.Command{Crews = crews}));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCrew(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command{Id = id}));
        }
        
    }
}