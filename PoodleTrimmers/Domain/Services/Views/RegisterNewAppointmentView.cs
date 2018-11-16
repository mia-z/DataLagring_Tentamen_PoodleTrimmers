using System;
using System.Threading;

namespace PoodleTrimmers.Domain.Services.Views
{
    public class RegisterNewAppointmentView : ViewService
    {
        private EntityHelper eh;
        
        public RegisterNewAppointmentView() : base("Register new appointment")
        {
            eh = new EntityHelper();
        }

        public void Run()
        {
            Display("Register a new Appointment");
            GetInput();
        }
        
        private void GetInput()
        {
            Console.Write("\nClient to use: ");
            var clientToUse = Console.ReadLine();
            int clientToUseId = eh.GetClientIdByName(clientToUse);
            if (clientToUseId == 0)
            {
                Console.WriteLine("Client not found, going back");
                Thread.Sleep(3000);
                return;
            }
            Console.Write("\nStylist to use (Enter first name or alias): ");
            var stylistToUse = Console.ReadLine();
            int stylistToUseById = eh.GetStylistIdByName(stylistToUse);
            if (stylistToUseById == 0)
            {
                Console.WriteLine("Stylist not found, going back");
                Thread.Sleep(3000);
                return;
            }
            
            Console.Write("\nEnter a date: ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime parsedDate))
            {
                Console.WriteLine("Invalid date entered, going back");
                Thread.Sleep(3000);
                return;
            }
            Console.Write("\nEnter a treatment: ");
            var treatment = Console.ReadLine();
            Console.Write("\nEnter a price: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal parsedDecimal))
            {
                Console.WriteLine("Invalid price entered, going back");
                Thread.Sleep(3000);
                return;
            }
            
            Console.WriteLine($"\nAdd appointment {treatment} with date {parsedDate}?\n(Y)es - (N)o");
            ConsoleKey input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.Y)
            {
                Console.WriteLine("Adding Appointment - may take a few seconds..");
                eh.AddAppointment(new Appointment(
                    clientToUseId, 
                    stylistToUseById,
                    parsedDate,
                    treatment,
                    parsedDecimal
                    ));
                Console.WriteLine("Appointment added, returning to main menu..");
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("Cancelling and returning to main menu..");
                Thread.Sleep(3000);
            }
        }
        
        protected override void Display(string title)
        {
            base.Display(title);
            Console.WriteLine("# Register a new Appointment\n");
        }
    }
}