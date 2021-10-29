using System.Threading.Tasks;
using System.Collections.Generic;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using Application.AppUsers;

namespace API.Controllers
{
    public class AppUserController : BaseApiController
    {

        [HttpGet]
        public async Task<ActionResult<List<AppUser>>> GetAppUser()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetAppUser(Guid id)
        {
            return await Mediator.Send(new Details.Query{Id = id});
        }

        [HttpPost]
        public async Task<IActionResult> CreateAppUser(AppUser appUser)
        {
            return Ok(await Mediator.Send(new Create.Command {AppUser = appUser}));
        }
    }
}

