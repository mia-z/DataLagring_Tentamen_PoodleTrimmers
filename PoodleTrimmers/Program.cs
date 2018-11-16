using System;
using PoodleTrimmers.Domain.Services.Views;

namespace PoodleTrimmers
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenuView mmv = new MainMenuView();
            mmv.Run();
        }
    }
}