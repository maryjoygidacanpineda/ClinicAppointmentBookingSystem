using ClinicAppointmentBookingSystemAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClinicAppointmentBookingSystemAPI.Data;
using System;

namespace ClinicAppointmentBookingSystemAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DoctorsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Doctor>>> GetDoctors()
        {
            return await _context.Doctors.ToListAsync();
        }
        [HttpPost]
        public async Task<IActionResult> CreateDoctor(Doctor doctor)
        {
            if (string.IsNullOrEmpty(doctor.Name))
                return BadRequest("Doctor name is required");

            _context.Doctors.Add(doctor);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Doctor created successfully",
                doctorId = doctor.DoctorId
            });
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDoctor(int id, Doctor updatedDoctor)
        {
            var doctor = await _context.Doctors.FindAsync(id);

            if (doctor == null)
                return NotFound("Doctor not found");

            doctor.Name = updatedDoctor.Name;
            doctor.Specialization = updatedDoctor.Specialization;

            await _context.SaveChangesAsync();

            return Ok(new { message = "Doctor updated successfully" });
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoctor(int id)
        {
            var doctor = await _context.Doctors.FindAsync(id);

            if (doctor == null)
                return NotFound("Doctor not found");

            _context.Doctors.Remove(doctor);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Doctor deleted successfully" });
        }
    }
}
