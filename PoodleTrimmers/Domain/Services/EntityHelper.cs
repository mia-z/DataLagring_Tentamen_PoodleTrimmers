using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PoodleTrimmers.Domain.Services
{
    public class EntityHelper
    {
        public void AddClient(Client c)
        {
            using (var context = new PoodleTrimmersDbContext())
            {
                context.Clients.Add(c);
                context.SaveChanges();
            }
        }

        public void AddStylist(Stylist s)
        {
            using (var context = new PoodleTrimmersDbContext())
            {
                context.Stylists.Add(s);
                context.SaveChanges();
            }
        }

        public void AddAppointment(Appointment a)
        {
            using (var context = new PoodleTrimmersDbContext())
            {
                context.Appointments.Add(a);
                context.SaveChanges();
            }
        }

        public int GetClientIdByName(string name)
        {
            using (var context = new PoodleTrimmersDbContext())
            {
                List<Client> clients = context.Clients.ToList();
                foreach (Client c in clients)
                {
                    if (name == c.Name)
                    {
                        return c.Id;
                    }
                }

                return 0;
            }
        }

        public int GetStylistIdByName(string name)
        {
            using (var context = new PoodleTrimmersDbContext())
            {
                List<Stylist> stylists = context.Stylists.ToList();
                foreach (Stylist s in stylists)
                {
                    if (name == s.FirstName || name == s.Handle)
                    {
                        return s.Id;
                    }
                }

                return 0;
            }
        }
        
        public void ListAppointments()
        {
            using (var context = new PoodleTrimmersDbContext())
            {
                var appointments = context.Appointments.ToList();
                var clients = context.Clients.ToList();
                var stylists = context.Stylists.ToList();
    
                for(int x = -1; x < context.Appointments.Count(); x++)
                {
                    Console.WriteLine($"{appointments[x].AppointmentDate} {clients[appointments[x].Id]} " +
                                      $"{stylists[appointments[x].Id]} {appointments[x].Treatment}");
                }
            }
        }
    }
}