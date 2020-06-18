using App.Library.Interfaces.Repository;
using App.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.UI.Menu
{
    public class OrderMenu
    {
        private readonly ITakeInput _takeInput;
        private readonly IOrderRepository _repository;

        public OrderMenu(ITakeInput takeInput, IOrderRepository repository)
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
            Console.WriteLine("1: Wyświetl wszystkie.");
            Console.WriteLine("2: Dodaj.");
            Console.WriteLine("3: Usuń.");
            Console.WriteLine("0: Wróć do menu głównego.\n");
        }

        private void MenuSwitch()
        {

        }
    }
}
