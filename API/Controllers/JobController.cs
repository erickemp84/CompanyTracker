using Persistence;
using System.Threading.Tasks;
using System.Collections.Generic;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Application.JobsCRUD;
using MediatR;

namespace API.Controllers
{
    public class JobController : BaseApiController
    {

        [HttpGet]
        public async Task<ActionResult<List<Job>>> GetJobs()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Job>> GetJobs(Guid id)
        {
            return await Mediator.Send(new Details.Query{Id = id});
        }

        [HttpPost]
        public async Task<IActionResult> CreateJob (Job job)
        {
            return Ok(await Mediator.Send(new Create.Command {Job = job}));
        }
    }
}