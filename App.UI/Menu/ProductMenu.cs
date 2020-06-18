using App.Library.Interfaces.Repository;
using App.UI.Interfaces;
using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.UI.Menu
{
    public class ProductMenu
    {
        private readonly ITakeInput _takeInput;
        private readonly IProductRepository _repository;

        public ProductMenu(ITakeInput takeInput, IProductRepository repository)
        {
            _takeInput = takeInput;
            _repository = repository;
        }
        public void Initialize()
        {
            MenuText();
            SwitchMenu();

        }
        private void MenuText()
        {
            Console.WriteLine("1: Wyświetl wszystkie.");
            Console.WriteLine("2: Dodaj.");
            Console.WriteLine("3: Usuń.");
            Console.WriteLine("0: Wróć do menu głównego.\n");

        }

        private void SwitchMenu()
        {
            int option = _takeInput.MenuInput();
            switch (option)
            {
                case (1):
                    var products = _repository.GetAll();
                    var companiesTable = new ConsoleTable("Id", "Name", "Price/kg");
                    foreach (var prod in products)
                    {
                        companiesTable.AddRow(prod.Id, prod.Name, prod.PricePerKg);
                    }
                    companiesTable.Write();
                    Console.WriteLine();
                    Initialize();
                    break;

                case (2):
                    Console.Write("Podaj nazwę produktu: ");
                    var name = _takeInput.StringInput();

                    Console.Write("Podaj cenę za kilogram: ");
                    var price = _takeInput.DoubleInput();

                    _repository.Create(name, price);
                    Initialize();
                    break;

                case (3):
                    Console.Write("Podaj id produktu do usunięcia: ");
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
