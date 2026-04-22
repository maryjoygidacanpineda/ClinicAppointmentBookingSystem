using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;   // Needed for EF Core methods
using ClinicAppointmentBookingSystemAPI.Data;   // Namespace for AppDbContext
using ClinicAppointmentBookingSystemAPI.Models; // Namespace for User model

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

        [HttpPost("login")]
        public async Task<ActionResult<User>> Login(string username, string password)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Username == username && u.Password == password);

            if (user == null) return Unauthorized();
            return user;
        }
    }
}
