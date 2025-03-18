using AutoMapper;
using HealthcareWebApi.OutgoingDtos.OutgoingUser;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Shared.IncomingDtos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HealthcareWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class UserController(IUserService _userService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public async Task<OutgoingUserDto> GetById(long id)
        {
            var user = await _userService.GetById(id);
            var res = _mapper.Map<OutgoingUserDto>(user);
            return res;

        }
        [HttpPost]
        public async Task<ActionResult> CreateUser([FromBody] IncomingUserDto user)
        {
            await _userService.CreateUserAsync(user);
            return Ok();
        }

    }
}
