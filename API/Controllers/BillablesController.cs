using Persistence;
using System.Threading.Tasks;
using System.Collections.Generic;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;

namespace API.Controllers
{
    public class BillablesController : BaseApiController
    {
        private readonly DataContext _context;
        public BillablesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Billables>>> GetBillables()
        {
            return await _context.Billables.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Billables>> GetBillables(Guid id)
        {
            return await _context.Billables.FindAsync(id);
        }

    }
}