using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SYLBackend.DTO.UserDTO;
using SYLBackend.Models;

namespace SYLBackend.Interfaces
{
    interface IUserProcessor
    {
        Task<bool> AddNewUser(NewUserDTO data);
        Task<bool> ModifyUser(ModifyUserDTO data);
        Task<bool> DeleteUser(UserIdDTO data);
        Task<bool> VerifyUser(UserLoginDTO data);
        Task<Users> GetUserById(UserIdDTO data);
        Task<Users> GetUserByEmail(string userEmail);
    }
}
