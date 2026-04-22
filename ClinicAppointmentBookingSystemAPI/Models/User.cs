namespace ClinicAppointmentBookingSystemAPI.Models
{
    public class User
    {
        public int UserId { get; set; }   // Primary Key
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }  // e.g. "Admin" or "Patient"
    }
}
