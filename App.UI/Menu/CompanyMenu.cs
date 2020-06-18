﻿using App.Library.Interfaces.Repository;
using App.Library.Models;
using App.UI.Interfaces;
using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.UI.Menu
{
    public class CompanyMenu
    {
        private readonly ICompanyRepository _repository;
        private readonly ITakeInput _takeInput;

        public CompanyMenu(ICompanyRepository repository, ITakeInput takeInput)
        {
            _repository = repository;
            _takeInput = takeInput;
        }

        public void Initialize()
        {
            MenuText();
            MenuSwitch();
        }

        private void MenuText()
        {
            Console.WriteLine("MENU FIRM");
            Console.WriteLine("1: Wyświetl wszystkie.");
            Console.WriteLine("2: Dodaj.");
            Console.WriteLine("3: Usuń.");
            Console.WriteLine("0: Wróć do menu głównego.\n");

        }


        private void MenuSwitch()
        {
            int option = _takeInput.IntInput();
            switch (option)
            {
                case (1):
                    var companies = _repository.GetAll();
                    var companiesTable = new ConsoleTable("Id", "Name", "Country", "Adress");
                    foreach (var comp in companies)
                    {
                        companiesTable.AddRow(comp.Id, comp.Name, comp.Country, comp.Adress);
                    }
                    companiesTable.Write();
                    Console.WriteLine();
                    Initialize();
                    break;

                case (2):
                    Console.Write("Podaj nazwę firmy: ");
                    var name = _takeInput.StringInput();

                    Console.Write("Podaj kraj: ");
                    var country = _takeInput.StringInput();

                    Console.Write("Podaj adres firmy: ");
                    var adress = _takeInput.StringInput();

                    _repository.Create(name, country, adress);
                    Initialize();
                    break;

                case (3):
                    Console.Write("Podaj id firmy do usunięcia: ");
                    var idToDel = _takeInput.IntInput();
                    _repository.Delete(idToDel);
                    Initialize();
                    break;

                case (0):                   
                    break;

                default:
                    Console.WriteLine("Wybrałeś nieistniejącą opcję.");
                    Initialize();
                    break;
            }
        }
    }
}
