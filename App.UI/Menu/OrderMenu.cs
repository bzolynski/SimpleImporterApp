using App.Library.Interfaces;
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
        private readonly IOrderRepository _orderRepository;
        private readonly IPrintTables _printTables;
        private readonly IOrderedProductRepository _orderedProductRepository;
        private readonly IValidation _validation;

        public OrderMenu(ITakeInput takeInput, IOrderRepository orderRepository, IPrintTables printTables, IOrderedProductRepository orderedProductRepository, IValidation validation)
        {
            _takeInput = takeInput;
            _orderRepository = orderRepository;
            _printTables = printTables;
            _orderedProductRepository = orderedProductRepository;
            _validation = validation;
        }
        public void Initialize()
        {
            MenuText();
            MenuSwitch();
        }

        private void MenuText()
        {
            Console.WriteLine("1: Wyświetl wszystkie.");
            Console.WriteLine("2: Szczegóły.");
            Console.WriteLine("3: Dodaj.");
            Console.WriteLine("4: Usuń.");
            Console.WriteLine("0: Wróć do menu głównego.\n");
        }

        private void MenuSwitch()
        {
            int option = _takeInput.MenuInput();
            switch (option)
            {
                case (1):
                    Console.Clear();

                    _printTables.OrdersTable();

                    Initialize();
                    break;

                case (2):
                    Console.Clear();
                    _printTables.OrdersTable();
                    Console.Write("Podaj id zamówienia: ");
                    int id = _takeInput.MenuInput();

                    if (_validation.DoesOrderExist(id))
                        _printTables.OrderDetailsTable(id);
                    else
                        Console.WriteLine("Wybrane zamówienie nie istnieje! \n");

                    
                    Initialize();
                    break;

                case (3):
                    Console.Clear();
                    _printTables.SellersTable();

                    int sellerId;
                    do
                    {
                        Console.Write("Podaj istniejące id sprzedawcy: ");
                        sellerId = _takeInput.IntInput();

                    } while (!_validation.DoesSellerExist(sellerId));

                    var orderId = _orderRepository.Create(sellerId);

                    do
                    {
                        if(_printTables.ProductsTable() < 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Brak produktów w bazie. Najpierw dodaj produkty potem złóż zamówienie!!!\n");
                            Initialize();
                            break;
                        }
                        int productId;

                        do
                        {
                            Console.Write("Podaj istniejące id produktu: ");
                            productId = _takeInput.IntInput();

                        } while (!_validation.DoesProductExist(productId));

                        Console.Write("Podaj ilość: ");
                        var quantity = _takeInput.DecimalInput();

                        _orderedProductRepository.Create(orderId, productId, quantity);

                        Console.Write("Aby dodać kolejny produkt wprowadź 1, aby przejść dalej wprowadź 0: ");
                        var cont = _takeInput.IntInput();

                        if (cont == 1)
                            continue;
                        else if (cont == 0)
                            break;
                        else
                            Console.WriteLine("Wprowadź 0 albo 1!!!");

                    } while (true);

                    Console.Clear();

                    Initialize();
                    break;

                case (4):
                    _printTables.OrdersTable();
                    Console.Write("Podaj id zamówienia do usunięcia: ");
                    var idToDel = _takeInput.IntInput();
                    _orderRepository.Delete(idToDel);
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
