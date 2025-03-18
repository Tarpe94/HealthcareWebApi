using System.ComponentModel.DataAnnotations;
using AutoMapper;
using HealthcareWebApi.OutgoingDtos.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Shared.IncomingDtos;

namespace HealthcareWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IUserService _userService, IMapper _mapper): ControllerBase
    {
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<LoginResponseDto>> LoginAsync([FromBody, Required] LoginDto data)
        {
            var tokens = await _userService.LoginUserAsync(data.Email, data.Password);
            var response = _mapper.Map<LoginResponseDto>(tokens);
            return Ok(response);
        }
    }
}
