using CMS.Core.Dto;
using CMS.Data;
using CMS.Data.Models;
using CMS.Service.Services.Category;
using CMS.Service.Services.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.API.Controllers
{
    
    public class UserController : BaseController
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult GetAll()
        {
           var users =  _userService.GetUsers();
           return Ok(GetRespons(users));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CreateUserDto dto)
        {
            await _userService.Create(dto);
            return Ok(GetRespons());
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody]UpdateUserDto dto)
        {
            await _userService.Update(dto);
            return Ok(GetRespons());
        }

        [HttpDelete]
        public IActionResult Delete(string id)
        {
            _userService.Delete(id);
            return Ok(GetRespons());
        }

    }
}
