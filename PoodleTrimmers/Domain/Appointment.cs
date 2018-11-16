using System;
using System.Data;

namespace PoodleTrimmers.Domain
{
    public class Appointment
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int StylistId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Treatment { get; set; }
        public decimal Price { get; set; }

        public Appointment()
        {
            //EMPTY CONSTRUCTOR MEMERY
        }

        public Appointment(int clientId, int stylistId, DateTime appointmentDate, string treatment, decimal price)
        {
            ClientId = clientId;
            StylistId = stylistId;
            AppointmentDate = appointmentDate;
            Treatment = treatment;
            Price = price;
        }
    }
}