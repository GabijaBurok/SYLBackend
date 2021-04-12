using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SYLBackend.DTO.UserDTO;
using SYLBackend.Models;

namespace SYLBackend.Interfaces
{
    public interface IUserProcessor
    {
        Task<bool> AddNewUser(NewUserDTO data);
        Task<bool> ModifyUser(ModifyUserDTO data);
        Task<bool> DeleteUser(string userId);
        Task<bool> VerifyUser(UserLoginDTO data);
        Task<Users> GetUserById(string userId);
        Task<Users> GetUserByEmail(string userEmail);
    }
}
