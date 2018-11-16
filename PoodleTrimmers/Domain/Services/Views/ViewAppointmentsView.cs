using System;

namespace PoodleTrimmers.Domain.Services.Views
{
    public class ViewAppointmentsView : ViewService
    {
        private EntityHelper eh;
        
        public ViewAppointmentsView() : base("View Appointments")
        {
            eh = new EntityHelper();
        }

        public void Run()
        {
            eh.ListAppointments();
            Console.ReadLine();
        }
    }
}