using System.Text.Json.Serialization;

namespace ClinicAppointmentBookingSystemAPI.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }   // PK
        public string Name { get; set; }
        public string Specialization { get; set; } // e.g. "General Practitioner"


        [JsonIgnore] // 👈 ADD THIS
        public List<Appointment>? Appointments { get; set; }
    }
}
