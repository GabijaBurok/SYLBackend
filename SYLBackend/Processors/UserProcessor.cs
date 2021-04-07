using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SYLBackend.DTO.UserDTO;
using SYLBackend.Interfaces;
using SYLBackend.Models;

namespace SYLBackend.Processors
{
    public class UserProcessor : IUserProcessor
    {
        public Task<bool> AddNewUser(NewUserDTO data)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUser(UserIdDTO data)
        {
            throw new NotImplementedException();
        }

        public Task<Users> GetUserByEmail(string userEmail)
        {
            throw new NotImplementedException();
        }

        public Task<Users> GetUserById(UserIdDTO data)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ModifyUser(ModifyUserDTO data)
        {
            throw new NotImplementedException();
        }

        public Task<bool> VerifyUser(UserLoginDTO data)
        {
            throw new NotImplementedException();
        }
    }
}
