using System;

namespace PoodleTrimmers.Domain.Services
{
    public abstract class ViewService
    {        
        protected ViewService(string title)
        {
            InitialDisplay(title);
        }

        protected ViewService(string title, int menuType)
        {
            InitialDraw(title, menuType);
        }

        private void InitialDisplay(string title)
        {
            Console.Title = title;
            Console.Clear();
        }

        private void InitialDraw(string title, int menuType)
        {
            Console.Title = title;
            Console.Clear();
            string[] menu = MenuPopulatorService.ReturnMenu(menuType);
            for(int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine($"{i+1}. {menu[i]}");
            }
        }

        protected virtual void Display(string title)
        {
            Console.Title = title;
            Console.Clear();
        }

        protected virtual void Display(string title, int menuType)
        {
            Console.Title = title;
            Console.Clear();
            string[] menu = MenuPopulatorService.ReturnMenu(menuType);
            for(int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine($"{i+1}. {menu[i]}");
            }
        }
    }
}