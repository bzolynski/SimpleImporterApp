using App.Library.Interfaces;
using App.Library.Interfaces.Repository;
using App.UI.Interfaces;
using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.UI.Menu
{
    public class SellerMenu
    {
        private readonly ITakeInput _takeInput;
        private readonly ISellerRepository _sellerRepository;
        private readonly IValidation _validation;
        private readonly IPrintTables _printTables;

        public SellerMenu(ITakeInput takeInput, ISellerRepository sellerRepository, IValidation validation, IPrintTables printTables)
        {
            _takeInput = takeInput;
            _sellerRepository = sellerRepository;
            _validation = validation;
            _printTables = printTables;
        }
        public void Initialize()
        {
            MenuText();
            MenuSwitch();
        }

        private void MenuText()
        {
            Console.WriteLine("MENU SPRZEDAWCÓW");
            Console.WriteLine("1: Wyświetl wszystkich.");
            Console.WriteLine("2: Dodaj.");
            Console.WriteLine("3: Usuń.");
            Console.WriteLine("0: Wróć do menu głównego.\n");
        }

        private void MenuSwitch()
        {
            int option = _takeInput.MenuInput();
            switch (option)
            {
                case (1):
                    Console.Clear();

                    _printTables.SellersTable();

                    Initialize();
                    break;

                case (2):
                    Console.Clear();
                    Console.Write("Podaj imię: ");
                    var firstName = _takeInput.StringInput();
                    Console.Write("Podaj nazwisko: ");
                    var lastName = _takeInput.StringInput();

                    string email;
                    Console.Write("Podaj email: ");
                    do
                    {
                        email = _takeInput.StringInput();

                    } while (!_validation.IsValidEmail(email));

                    if (_printTables.CompaniesTable() < 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Brak firm w bazie. Najpierw dodaj firmę potem sprzedawcę!!!\n");
                        Initialize();
                        break;
                    }                    

                    int companyId;
                    do
                    {
                        Console.Write("Podaj istniejące id firmy: ");
                        companyId = _takeInput.IntInput();

                    } while (!_validation.DoesCompanyExist(companyId));

                    _sellerRepository.Create(firstName, lastName, email, companyId);
                    Console.Clear();
                    Initialize();
                    break;

                case (3):
                    Console.Clear();
                    _printTables.SellersTable();
                    Console.Write("Podaj id sprzedawcy do usunięcia: ");
                    var idToDel = _takeInput.IntInput();

                    Console.WriteLine("Aby usunąć wprowadź 1, aby anulować wprowadź dowolną liczbę");
                    var input = _takeInput.IntInput();
                    if (input == 1)
                        _sellerRepository.Delete(idToDel);

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
