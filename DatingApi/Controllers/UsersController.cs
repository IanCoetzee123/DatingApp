using DatingApi.Data;
using DatingApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(DataContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await context.Users.ToListAsync();

            if (users is null)
                return NotFound();

            return Ok(users);
        }

        [HttpGet("{Id:int}")]
        public async Task<ActionResult<AppUser>> GetUser(int Id)
        {
            var user = await context.Users.FindAsync(Id);

            if (user is null)
                return NotFound();

            return Ok(user);
        }
    }
}
