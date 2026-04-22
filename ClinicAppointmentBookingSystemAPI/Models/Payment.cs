namespace ClinicAppointmentBookingSystemAPI.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int AppointmentId { get; set; }
        public string Method { get; set; } // Cash, Card, Insurance
        public string InsuranceProvider { get; set; }
        public string PolicyNumber { get; set; }
    }
}
