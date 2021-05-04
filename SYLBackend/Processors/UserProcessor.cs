using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SYLBackend.Context;
using SYLBackend.DTO.UserDTO;
using SYLBackend.Interfaces;
using SYLBackend.Models;

namespace SYLBackend.Processors
{
    public class UserProcessor : IUserProcessor
    {
        private readonly SYLContext context;
        public UserProcessor(SYLContext context)
        {
            this.context = context;
        }

        public Task<bool> AddNewUser(NewUserDTO data) => Task.Run(() =>
        {
            Users user = new Users
            {
                userId = Guid.NewGuid().ToString(),
                userName = data.userName,
                userLastName = data.userLastName,
                userEmail = data.userEmail,
                userPassword = data.userPassword,
                userType = data.userType
            };
            try
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                return false;
            }
            return true;

        });

        public Task<bool> DeleteUser(string userId) => Task.Run(() =>
        {
            context.Remove(context.Users.Find(userId));
            context.SaveChanges();
            return true;
        });

        public Task<Users> GetUserByEmail(string userEmail)
        {
            throw new NotImplementedException();
        }

        public Task<Users> GetUserById(string userId)
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
