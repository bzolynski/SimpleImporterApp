using App.UI.Menu;
using System;

namespace App.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w aplikacji importera, wybierz co chcesz zrobić: ");
            MainMenu mainMenu = new MainMenu();
            mainMenu.Menu();
        }
        
    }
}
