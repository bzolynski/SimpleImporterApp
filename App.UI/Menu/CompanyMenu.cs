using App.Library.Interfaces.Repository;
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
        private readonly IPrintTables _printTables;

        public CompanyMenu(ICompanyRepository repository, ITakeInput takeInput, IPrintTables printTables)
        {
            _repository = repository;
            _takeInput = takeInput;
            _printTables = printTables;
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
                    Console.Clear();

                    _printTables.CompaniesTable();

                    Initialize();
                    break;

                case (2):
                    Console.Clear();

                    Console.Write("Podaj nazwę firmy: ");
                    var name = _takeInput.StringInput();

                    Console.Write("Podaj kraj: ");
                    var country = _takeInput.StringInput();

                    Console.Write("Podaj adres firmy: ");
                    var adress = _takeInput.StringInput();

                    _repository.Create(name, country, adress);
                    Console.Clear();

                    Initialize();
                    break;

                case (3):
                    Console.Clear();
                    _printTables.CompaniesTable();

                    Console.Write("Podaj id firmy do usunięcia: ");
                    var idToDel = _takeInput.IntInput();

                    Console.WriteLine("Aby usunąć wprowadź 1, aby anulować wprowadź dowolną liczbę");
                    var input = _takeInput.IntInput();
                    if (input == 1)
                        _repository.Delete(idToDel);
                    Console.Clear();
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
