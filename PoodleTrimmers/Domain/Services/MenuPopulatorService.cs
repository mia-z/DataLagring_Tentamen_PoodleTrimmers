namespace PoodleTrimmers.Domain.Services
{
    public struct MenuPopulatorService
    {
        private static readonly string[] MainMenu =
        {
            "Register new client",
            "Create new stylist",
            "Create appointments",
            "List appointments",
            "Exit"
        };

        public static string[] ReturnMenu(int menuChoice)
        {
            switch (menuChoice)
            {
                case 1: return MainMenu;
                default: return null;
            }
        }
    }
}