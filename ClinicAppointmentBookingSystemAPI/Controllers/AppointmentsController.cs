using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClinicAppointmentBookingSystemAPI.Data;
using ClinicAppointmentBookingSystemAPI.Models;

namespace ClinicAppointmentBookingSystemAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AppointmentsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Doctor>>> GetDoctors()
        {
            return await _context.Doctors.ToListAsync();
        }

        // POST (BOOK APPOINTMENT)
        [HttpPost]
        public async Task<IActionResult> CreateAppointment(Appointment appointment)
        {
            var doctor = await _context.Doctors.FirstOrDefaultAsync();

            if (doctor == null)
                return BadRequest("No doctor found");

            appointment.DoctorId = doctor.DoctorId;
            appointment.Status = "Scheduled";

            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Appointment saved successfully",
                appointmentId = appointment.AppointmentId
            });
        }

        // UPDATE STATUS
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Appointment updated)
        {
            var appt = await _context.Appointments.FindAsync(id);

            if (appt == null)
                return NotFound();

            appt.Status = updated.Status;
            appt.PaymentMethod = updated.PaymentMethod;

            await _context.SaveChangesAsync();
            return Ok("Updated");
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var appt = await _context.Appointments.FindAsync(id);

            if (appt == null)
                return NotFound();

            _context.Appointments.Remove(appt);
            await _context.SaveChangesAsync();

            return Ok("Deleted");
        }
    }
}