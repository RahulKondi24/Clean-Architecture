using Microsoft.AspNetCore.Mvc;
using Moq;
using MyApp.API.Controllers;
using MyApp.Application.Services.Interfaces;
using MyApp.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Tests
{
    public class UserControllerTests
    {
        [Fact]
        public void GetAllUsers_Returns_All_Users()
        {
            // Arrange
            var mockUserService = new Mock<IUserService>();
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
                }
                // Add more users as needed for your test case
            };
            mockUserService.Setup(service => service.GetAllUsers()).Returns(expectedUsers);

            var controller = new UserController(mockUserService.Object);

            // Act
            var result = controller.Get();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var users = Assert.IsAssignableFrom<IList<User>>(okResult.Value);
            Assert.Equal(expectedUsers.Count, users.Count);
            // Additional assertions as needed to check if the returned users match the expected users
        }
    }
}
