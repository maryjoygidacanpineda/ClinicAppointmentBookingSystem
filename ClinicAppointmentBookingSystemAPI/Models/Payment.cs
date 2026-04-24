namespace ClinicAppointmentBookingSystemAPI.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int AppointmentId { get; set; }
        public string Method { get; set; } // Cash, Card, Insurance
    }
}
