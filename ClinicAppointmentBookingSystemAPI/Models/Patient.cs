namespace ClinicAppointmentBookingSystemAPI.Models
{
    public class Patient
    {
        public int PatientId { get; set; }   // Auto-increment PK
        public string FullName { get; set; }
        public DateTime Birthdate { get; set; }

        // Computed property (not stored in DB)
        public int Age => DateTime.Now.Year - Birthdate.Year -
            (DateTime.Now.DayOfYear < Birthdate.DayOfYear ? 1 : 0);

        public string Gender { get; set; }
        public string ContactInfo { get; set; }
        public string ChiefComplaint { get; set; }

        // Medical Informations
        public string BloodType { get; set; }
        public string Allergies { get; set; }
        public string CurrentMedications { get; set; }
        public string MedicalHistory { get; set; }

        // Navigation property
        public ICollection<Appointment> Appointments { get; set; }
    }
}
