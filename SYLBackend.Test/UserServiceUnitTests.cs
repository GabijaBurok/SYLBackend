using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SYLBackend.Context;
using SYLBackend.DTO.UserDTO;
using SYLBackend.Models;
using SYLBackend.Processors;

namespace SYLBackend.Test
{
    [TestClass]
    public class UserTests
    {   
        [TestMethod]
        public void Add_User_With_Valid_Data_Succeeds()
        {
            NewUserDTO user1 = new NewUserDTO
            {
                userName = "Test",
                userLastName = "Test",
                userEmail = "test@test.com",
                userPassword = "TESst123@!",
                userType = 3
            };
            
            var mock_UserDb_set = new Mock<DbSet<Users>>();
            var mock_context = new Mock<SYLContext>();
          
            mock_context.Setup(m => m.Users).Returns(mock_UserDb_set.Object);

            var processor = new UserProcessor(mock_context.Object);
            processor.AddNewUser(user1);

            mock_UserDb_set.Verify(m => m.Add(It.IsAny<Users>()), Times.Once());
            mock_context.Verify(m => m.SaveChanges(), Times.Once());
        }
    }
}
