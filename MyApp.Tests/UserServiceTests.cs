using Moq;
using MyApp.Application.Repositories;
using MyApp.Application.Services.Implementations;
using MyApp.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Tests
{
    public class UserServiceTests
    {
        [Fact]
        public void GetAllUsers_Returns_All_Users()
        {
            // Arrange
            var mockUserRepository = new Mock<IUserRepository>();
            var expectedUsers = new List<User>
            {
                new User
                {
                    Id = 1,
                    Email = "kirtesh@example.com",
                    UserName = "kirtesh",
                    Password = "password123",
                    ReferralId = "REF123",
                    ReferredId = "REF456",
                    Tokens = 100,
                    RoleId = 1 // Assuming 1 represents a specific role
                },
                new User
                {
                    Id = 2,
                    Email = "mahesh@example.com",
                    UserName = "mahesh",
                    Password = "password456",
                    ReferralId = "REF789",
                    ReferredId = "REF101",
                    Tokens = 50,
                    RoleId = 2 // Assuming 2 represents a different role
                },
            };
            mockUserRepository.Setup(repo => repo.GetAllUsers()).Returns(expectedUsers);

            var userService = new UserService(mockUserRepository.Object);

            // Act
            var result = userService.GetAllUsers();

            // Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<IEnumerable<User>>(result);
            // Additional assertions to verify returned users match expectedUsers
        }
    }
}
