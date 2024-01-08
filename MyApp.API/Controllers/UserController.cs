using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.Application.Services.Interfaces;
using MyApp.Domain.Entites;

namespace MyApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet("getusers")]
        public ActionResult<IList<User>> Get()
        {
            return Ok(this.userService.GetAllUsers());
        }
    }
}
