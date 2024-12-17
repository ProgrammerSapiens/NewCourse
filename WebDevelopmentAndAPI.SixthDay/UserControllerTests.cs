using Xunit;
using Moq;
using WebDevelopmentAndAPI.SecondDay;
using WebDevelopmentAndAPI.SecondDay.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace WebDevelopmentAndAPI.SixthDay
{
    public class UserControllerTests
    {
        private readonly Mock<IUserService> _userServiceMock;
        private readonly UserController _controller;

        public UserControllerTests()
        {
            _userServiceMock = new Mock<IUserService>();
            _controller = new UserController(_userServiceMock.Object);
        }

        [Fact]
        public void GetUsers_ReturnsOkResult_WithUserList()
        {
            var users = new List<User>
            {
                new User { Id = 1, Name = "John Doe"},
                new User { Id = 2, Name = "Jane Doe"}
            };
            _userServiceMock.Setup(service => service.LoadUsers()).Returns(users);

            var result = _controller.GetUsers();

            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnUsers = Assert.IsType<List<User>>(okResult.Value);
            Assert.Equal(2, returnUsers.Count);
        }

        [Fact]
        public void GetUsersById_ExistingId_ReturnsOkResult()
        {
            var user = new User { Id = 1, Name = "John Doe" };
            _userServiceMock.Setup(service => service.LoadUsers()).Returns(new List<User> { user });

            var result = _controller.GetUsersById(1);

            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnUser = Assert.IsType<User>(okResult.Value);
            Assert.Equal(user.Id, returnUser.Id);
            Assert.Equal(user.Name, returnUser.Name);
        }

        [Fact]
        public void GetUsersById_NonExistingId_ReturnsNotFoundResult()
        {
            _userServiceMock.Setup(service => service.LoadUsers()).Returns(new List<User>());

            var result = _controller.GetUsersById(4);

            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void CreateUser_ValidUser_ReturnsCreatedResult()
        {
            var user = new User { Id = 1, Name = "Jane Doe" };

            var result = _controller.CreateUser(user);

            var createdResult = Assert.IsType<CreatedAtActionResult>(result);
            var returnedUser = Assert.IsType<User>(createdResult.Value);
            Assert.Equal(user.Id, returnedUser.Id);
            Assert.Equal(user.Name, returnedUser.Name);
        }
    }
}