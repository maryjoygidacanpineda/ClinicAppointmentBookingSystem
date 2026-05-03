using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;   
using ClinicAppointmentBookingSystemAPI.Data;  
using ClinicAppointmentBookingSystemAPI.Models; 

namespace ClinicAppointmentBookingSystemAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminsController : ControllerBase
    {
        private readonly AppDbContext _context;

        // Corrected constructor parameter
        public AdminsController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register(Admin admin)
        {
            var exists = await _context.Admins
                .AnyAsync(u => u.Username == admin.Username);

            if (exists)
                return BadRequest("Username already exists");

            _context.Admins.Add(admin);
            await _context.SaveChangesAsync();

            return Ok(new { message = "User registered successfully" });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Admin login)
        {
            var admin = await _context.Admins
                .FirstOrDefaultAsync(u =>
                    u.Username == login.Username &&
                    u.Password == login.Password);

            if (admin == null)
                return Unauthorized(new { message = "Invalid credentials" });

            return Ok(new
            {
                message = "Login successful",
                adminId = admin.AdminId,
                username = admin.Username
            });
        }
    }
}
