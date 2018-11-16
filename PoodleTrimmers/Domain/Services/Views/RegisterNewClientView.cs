using System;
using System.Threading;

namespace PoodleTrimmers.Domain.Services.Views
{
    public class RegisterNewClientView : ViewService
    {
        private EntityHelper eh;
        
        public RegisterNewClientView() : base("Register new Client")
        {
            eh = new EntityHelper();
        }

        public void Run()
        {
            Display("Register a new Client");
            GetInput();
        }
        
        private void GetInput()
        {
            Console.Write("\nClient name: ");
            var name = Console.ReadLine();
            Console.Write("\nBreed: ");
            var breed = Console.ReadLine();
            
            Console.WriteLine($"\nAdd {name} with breed {breed}?\n(Y)es - (N)o");
            ConsoleKey input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.Y)
            {
                Console.WriteLine("Adding client - may take a few seconds..");
                eh.AddClient(new Client(name, breed));
                Console.WriteLine("Client added, returning to main menu..");
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
            Console.WriteLine("# Register a new Client\n");
        }
    }
}