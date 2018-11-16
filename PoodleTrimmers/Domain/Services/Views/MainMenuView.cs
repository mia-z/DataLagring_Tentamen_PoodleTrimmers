using System;
using System.Threading;

namespace PoodleTrimmers.Domain.Services.Views
{
    public class MainMenuView : ViewService
    {
        public MainMenuView() : base("Main Menu", 1)
        {
            
        }
        
        public void Run()
        {
            GetInput();
        }
        
        private void GetInput()
        {
            ConsoleKey input;
            do
            {
                Display("Main Menu", 1);
                input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        RegisterNewClientView rncv = new RegisterNewClientView();
                        rncv.Run();
                        break;
                    case ConsoleKey.D2:
                        RegisterNewStylistView rnsv = new RegisterNewStylistView();
                        rnsv.Run();
                        break;
                    case ConsoleKey.D3:
                        RegisterNewAppointmentView rnav = new RegisterNewAppointmentView();
                        rnav.Run();
                        break;
                    case ConsoleKey.D4:
                        ViewAppointmentsView vav = new ViewAppointmentsView();
                        vav.Run();
                        break;
                    case ConsoleKey.D5:
                        QuitPrompt();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid choice!");
                        Console.WriteLine("Press return to go back..");
                        Console.ReadLine();
                        break;
                }
            } while (input != ConsoleKey.D5);
        }

        protected void QuitPrompt()
        {
            Console.Clear();
            Console.WriteLine("Are you sure you want to quit?\n(Y)es - (N)o");
            ConsoleKey input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.Y)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Returning to main menu..");
                Thread.Sleep(3000);
            }
        }
        
        protected override void Display(string title, int menuType)
        {
            base.Display("Main Menu", 1);
            Console.WriteLine("Press a corresponding number to perform that action\n");
            Console.Write("> ");
        }
    }
}