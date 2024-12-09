using Microsoft.AspNetCore.Mvc;

namespace WebDevelopmentAndAPI.SecondDay.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _userService.LoadUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUsersById(int id)
        {
            var users = _userService.LoadUsers();
            var user = users.FirstOrDefault(x => x.Id == id);

            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] User newUser)
        {
            _userService.AddUser(newUser);
            return CreatedAtAction(nameof(GetUsers), new { id = newUser.Id }, newUser);
        }
    }
}
