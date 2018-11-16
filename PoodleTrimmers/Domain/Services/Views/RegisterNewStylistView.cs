using System;
using System.Threading;

namespace PoodleTrimmers.Domain.Services.Views
{
    public class RegisterNewStylistView : ViewService
    {
        private EntityHelper eh;
        
        public RegisterNewStylistView() : base("Register new Stylist")
        {
            eh = new EntityHelper();
        }

        public void Run()
        {
            Display("Register a new Stylist");
            GetInput();
        }
        
        private void GetInput()
        {
            Console.Write("\nFirst name: ");
            var fname = Console.ReadLine();
            Console.Write("\nLast name: ");
            var lname = Console.ReadLine();
            Console.Write("\nHandle/Alias: ");
            var handle = Console.ReadLine();
            Console.Write("\nSocial Security Number: ");
            if (!int.TryParse(Console.ReadLine(), out int i))
            {
                Console.WriteLine("Invalid input detected - press return to go back");
                Console.ReadLine();
            }
            
            Console.WriteLine($"\nAdd {fname} with handle {handle}?\n(Y)es - (N)o");
            ConsoleKey input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.Y)
            {
                Console.WriteLine("Adding Stylist - may take a few seconds..");
                eh.AddStylist(new Stylist(fname, lname, handle, i));
                Console.WriteLine("Stylist added, returning to main menu..");
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
            Console.WriteLine("# Register a new Stylist\n");
        }
    }
}