using Persistence;
using System.Threading.Tasks;
using System.Collections.Generic;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace API.Controllers
{
    public class JobController : BaseApiController
    {
        private readonly DataContext _context;

        public JobController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Job>>> GetJobs()
        {
            return await _context.Jobs.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Job>> GetJobs(Guid id)
        {
            return await _context.Jobs.FindAsync(id);
        }
    }
}