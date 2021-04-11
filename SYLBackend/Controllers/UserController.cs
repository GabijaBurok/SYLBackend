using Microsoft.AspNetCore.Mvc;
using SYLBackend.DTO.UserDTO;
using SYLBackend.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYLBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserProcessor _userProcessor;

        public UserController(IUserProcessor userProcessor)
        {
            _userProcessor = userProcessor;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] NewUserDTO data)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public async Task<IActionResult> ModifyUser([FromBody] ModifyUserDTO data)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(string userId)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IActionResult> UserLogin([FromBody] UserLoginDTO data)
        {
            throw new NotImplementedException();
        }
    }
}
