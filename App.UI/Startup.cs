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

        public Startup(ISampleData sampleData, ITakeInput takeInput)
        {
            _sampleData = sampleData;
            _takeInput = takeInput;
        }

        public void InitializeDatabase()
        {
            _sampleData.PopulateCompanies();
            _sampleData.PopulateProducts();
            _sampleData.PopulateSellers();
        }

        public void Run()
        {
            Console.WriteLine("Witaj w aplikacji importera, wybierz co chcesz zrobić: ");
            //Menu.TextMenu mainMenu = new Menu.TextMenu();
            mainMenu.MainMenu();
            _takeInput.MenuOptions();
        }
    }
}
