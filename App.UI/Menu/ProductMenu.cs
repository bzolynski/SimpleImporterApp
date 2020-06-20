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
        private readonly IPrintTables _printTables;

        public ProductMenu(ITakeInput takeInput, IProductRepository repository, IPrintTables printTables)
        {
            _takeInput = takeInput;
            _repository = repository;
            _printTables = printTables;
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
                    Console.Clear();
                    _printTables.ProductsTable();

                    Initialize();
                    break;

                case (2):
                    Console.Clear();
                    Console.Write("Podaj nazwę produktu: ");
                    var name = _takeInput.StringInput();

                    Console.Write("Podaj cenę za kilogram: ");
                    var price = _takeInput.DecimalInput();

                    _repository.Create(name, price);
                    Console.Clear();
                    Initialize();
                    break;

                case (3):
                    Console.Clear();
                    _printTables.ProductsTable();
                    Console.Write("Podaj id produktu do usunięcia: ");
                    var idToDel = _takeInput.IntInput();

                    Console.WriteLine("Czy jesteś pewny, że chcesz usunąć ten produkt? Po usunięciu produktu w szczegółach zamówienia mogą pojawić się błędy.");
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
