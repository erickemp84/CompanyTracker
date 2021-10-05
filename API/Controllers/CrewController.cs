using Persistence;
using System.Threading.Tasks;
using System.Collections.Generic;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace API.Controllers
{
    public class CrewController : BaseApiController
    {

        private readonly DataContext _context;

        public CrewController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Crews>>> GetCrews()
        {
            return await _context.Crews.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Crews>> GetCrews(Guid id)
        {
            return await _context.Crews.FindAsync(id);
        }
        
    }
}