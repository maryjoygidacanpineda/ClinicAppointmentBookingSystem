namespace ClinicAppointmentBookingSystemAPI.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }   // PK
        public string Name { get; set; }
        public string Specialization { get; set; } // e.g. "General Practitioner"

        // Navigation property
        public ICollection<Appointment> Appointments { get; set; }
    }
}
