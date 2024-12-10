using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebDevelopmentAndAPI.ThirdDay.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(string name)
        {
            var user = new User { Name = name };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok(user);
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetUsersFromDb()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
