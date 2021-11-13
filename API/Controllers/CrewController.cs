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
        
    }
}