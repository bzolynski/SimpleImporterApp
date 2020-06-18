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
        private readonly ISellerRepository _repository;

        public SellerMenu(ITakeInput takeInput, ISellerRepository repository)
        {
            _takeInput = takeInput;
            _repository = repository;
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
                    var sellers = _repository.GetAll();
                    // TODO: dodać nazwę firmy
                    var sellersTable = new ConsoleTable("Id", "Full Name", "Email");
                    foreach (var sell in sellers)
                    {
                        sellersTable.AddRow(sell.Id, sell.FullName, sell.Email);
                    }
                    sellersTable.Write();
                    Console.WriteLine();
                    Initialize();
                    break;

                case (2):
                    Console.Write("Podaj imię: ");
                    var firstName = _takeInput.StringInput();
                    Console.Write("Podaj nazwisko: ");
                    var lastName = _takeInput.StringInput();
                    Console.Write("Podaj email: ");
                    var email = _takeInput.StringInput();
                    Console.Write("Podaj id firmy: ");
                    var companyId = _takeInput.IntInput();

                    _repository.Create(firstName, lastName, email, companyId);
                    Initialize();
                    break;

                case (3):
                    Console.Write("Podaj id sprzedawcy do usunięcia: ");
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
