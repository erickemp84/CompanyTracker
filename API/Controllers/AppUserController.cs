using System.Threading.Tasks;
using System.Collections.Generic;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using Application.AppUsers;
using MediatR;

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

        [HttpPut("{id}")]
        public async Task<IActionResult> EditAppUser(Guid id, AppUser appUser)
        {
            appUser.Id = id;
            return Ok(await Mediator.Send(new Edit.Command{AppUser = appUser}));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppUser(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command{Id = id}));
        }
    }
}

