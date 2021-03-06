using CMS.Core.Dto;
using CMS.Service.Services.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.API.Controllers
{
    public class AuthController : BaseController
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody]LoginDto dto)
        {
            var result = await _authService.LoginAsync(dto);
            return Ok(GetRespons(result));
        }

        [HttpPost]
        public async Task<IActionResult> AddFCM([FromBody] string token)
        {
            await _authService.SaveFcmToken(token,"123");
            return Ok(GetRespons());
        }





    }
}
