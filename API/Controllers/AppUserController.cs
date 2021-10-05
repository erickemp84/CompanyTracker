using Persistence;
using System.Threading.Tasks;
using System.Collections.Generic;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace API.Controllers
{
    public class AppUserController : BaseApiController
    {
        private readonly DataContext _context;
        public AppUserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<AppUser>>> GetAppUsers()
        {
            return await _context.AppUsers.ToListAsync();
        }

        [HttpGet("{id}")] 
        public async Task<ActionResult<AppUser>> GetAppUsers(Guid id)
        {
            return await _context.AppUsers.FindAsync(id);
        }
    }
}