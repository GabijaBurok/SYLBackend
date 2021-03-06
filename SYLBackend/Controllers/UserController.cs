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
            if (await Task.Run(() => _userProcessor.AddNewUser(data)))
                return Ok("User Added");
            else
                return BadRequest("This user already exists");
        }

        [HttpPut]
        public Task<IActionResult> ModifyUser([FromBody] ModifyUserDTO data)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public Task<IActionResult> DeleteUser(string userId)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IActionResult> UserLogin([FromBody] UserLoginDTO data)
        {
            if (await _userProcessor.VerifyUser(data))
            {
                return Ok(Task.Run(() => _userProcessor.GetUserByEmail(data.userEmail)));
            }
            else return BadRequest("Failed to log in");
        }
    }
}
