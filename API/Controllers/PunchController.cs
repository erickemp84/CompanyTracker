using Persistence;
using System.Threading.Tasks;
using System.Collections.Generic;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace API.Controllers
{
    public class PunchController : BaseApiController
    {
        private readonly DataContext _context;
        public PunchController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Punch>>> GetPunches()
        {
            return await _context.Punches.ToListAsync();
        }

        [HttpGet("{id}")] 
        public async Task<ActionResult<Punch>> GetPunch(Guid id)
        {
            return await _context.Punches.FindAsync(id);
        }
    }
}