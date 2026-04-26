namespace ClinicAppointmentBookingSystemAPI.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }

        // Patient info (from HTML)
        public string FullName { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string ContactInfo { get; set; }
        public string Disease { get; set; }

        // Medical
        public string Allergies { get; set; }
        public string Medication { get; set; }
        public string History { get; set; }

        // Appointment
        public DateTime DateTime { get; set; }
        public string Status { get; set; }

        // FK to Doctors table
        public int DoctorId { get; set; }

        // Payment
        public string PaymentMethod { get; set; }
    }
}