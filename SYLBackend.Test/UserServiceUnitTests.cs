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
        public UserTests()  //TODO kazkada i sita konstruktoriu perrasyti mock'u kurimus, kad nereiketu kiekviename metode
        {
            
        }
        [TestMethod]
        public void Add_User_With_Valid_Data_Succeeds()
        {
            
           //arrange
           //sukuriamas useris
            NewUserDTO user1 = new NewUserDTO
            {
                userName = "Test",
                userLastName = "Test",
                userEmail = "test@test.com",
                userPassword = "TESst123@!",
                userType = 3
            };
            
            //sukuriami mock dbSetui ir context
            var mock_UserDb_set = new Mock<DbSet<Users>>();
            var mock_context = new Mock<SYLContext>();
            //"sujungiami" dbSet ir context
            //kad contexto mock galetu grazinti dbSeto mock
            mock_context.Setup(m => m.Users).Returns(mock_UserDb_set.Object);
            //mock'inis contextas naudojamas sukurti processoriui
            var processor = new UserProcessor(mock_context.Object);

            //act
            //atliekamas veiksmas -> bandoma prideti vartotoja
            processor.AddNewUser(user1);

            //assert
            //verify'inama ar buvo pridetas useris i db
            mock_UserDb_set.Verify(m => m.Add(It.IsAny<Users>()), Times.Once());
            //verify'inama ar buvo called SaveChanges on the context
            mock_context.Verify(m => m.SaveChanges(), Times.Once());
            //jei kazkuris ir veiksmu nebuvo atliktas -> testas failina
        }
    }
}
