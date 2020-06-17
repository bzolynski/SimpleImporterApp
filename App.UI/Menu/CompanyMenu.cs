using App.Library.Interfaces;
using App.Library.Models;
using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.UI.Menu
{
    public class CompanyMenu
    {
        private readonly IRepository<CompanyModel> _repository;

        public CompanyMenu(IRepository<CompanyModel> repository)
        {
            _repository = repository;
        }
        public void MenuText()
        {
            Console.WriteLine("1: Wyświetl wszystkie.");
            Console.WriteLine("2: Wyświetl firmę o id: ");
            Console.WriteLine("3: Dodaj.");
            Console.WriteLine("4: Usuń.");
        }

        public void MenuSwitch(int option)
        {
            switch (option)
            {
                case (1):
                    var companies = _repository.GetAll();
                    //var table = new ConsoleTable("Id", "Name", "Country", "Adress")
                    break;

                default:
                    break;
            }
        }
    }
}
