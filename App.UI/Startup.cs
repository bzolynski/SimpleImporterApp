using App.Library.Data;
using App.Library.Interfaces;
using App.UI.Interfaces;
using App.UI.Menu;
using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.UI
{
    public class Startup : IStartup
    {
        private readonly ISampleData _sampleData;
        private readonly ITakeInput _takeInput;
        private readonly MainMenu _mainMenu;

        public Startup(ISampleData sampleData, ITakeInput takeInput, MainMenu mainMenu)
        {
            _sampleData = sampleData;
            _takeInput = takeInput;
            _mainMenu = mainMenu;
        }

        public void InitializeDatabase()
        {
            _sampleData.Initialize();
        }

        public void Run()
        {
            Console.WriteLine("Witaj w aplikacji importera, wybierz co chcesz zrobić: ");

            _mainMenu.Initialize();
        }
    }
}
