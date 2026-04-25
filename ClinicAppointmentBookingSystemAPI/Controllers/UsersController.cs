using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;   
using ClinicAppointmentBookingSystemAPI.Data;  
using ClinicAppointmentBookingSystemAPI.Models; 

namespace ClinicAppointmentBookingSystemAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        // Corrected constructor parameter
        public UsersController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register(User user)
        {
            var exists = await _context.Users
                .AnyAsync(u => u.Username == user.Username);

            if (exists)
                return BadRequest("Username already exists");

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok(new { message = "User registered successfully" });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] User login)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u =>
                    u.Username == login.Username &&
                    u.Password == login.Password);

            if (user == null)
                return Unauthorized(new { message = "Invalid credentials" });

            return Ok(new
            {
                message = "Login successful",
                userId = user.UserId,
                username = user.Username
            });
        }
    }
}
