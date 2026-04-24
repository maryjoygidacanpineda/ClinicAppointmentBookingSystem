namespace ClinicAppointmentBookingSystemAPI.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }   // PK
        public int PatientId { get; set; }       // FK
        public Patient Patient { get; set; }

        public int DoctorId { get; set; }        // FK
        public Doctor Doctor { get; set; }

        public DateTime DateTime { get; set; }
        public string ServiceDepartment { get; set; } // e.g. "General Consultation"
        public string Status { get; set; }           // Scheduled, Completed, Cancelled

        // Administrative Information
        public string PaymentMethod { get; set; }
      

        // Optional Enhancements
        public string UploadedDocuments { get; set; } // file path or URL
        public string DoctorNotes { get; set; }
        public string VisitHistory { get; set; }      // serialized list of past visits
    }
}
