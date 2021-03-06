﻿using App.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.UI.Menu
{
    /// <summary>
    /// Główne menu. Za pomocą swich'a można wybrać podmenu
    /// </summary>
    public class MainMenu
    {
        private readonly ITakeInput _takeInput;
        private readonly SellerMenu _sellerMenu;
        private readonly CompanyMenu _companyMenu;
        private readonly ProductMenu _productMenu;
        private readonly OrderMenu _orderMenu;

        public MainMenu(ITakeInput takeInput, SellerMenu sellerMenu, CompanyMenu companyMenu, ProductMenu productMenu, OrderMenu orderMenu)
        {
            _takeInput = takeInput;
            _sellerMenu = sellerMenu;
            _companyMenu = companyMenu;
            _productMenu = productMenu;
            _orderMenu = orderMenu;

        }

        public void Initialize()
        {
            Console.Clear();
            MainText();
            MenuSwitch();
        }

        private void MainText()
        {
            Console.WriteLine("MENU GŁÓWNE:");
            Console.WriteLine("1: Sprzedawcy.");
            Console.WriteLine("2: Firmy.");
            Console.WriteLine("3: Produkty.");
            Console.WriteLine("4: Zamówienia.");
            Console.WriteLine("0: Zamknij program\n");

        }


        private void MenuSwitch()
        {
            int option = _takeInput.MenuInput();
            switch (option)
            {
                case (1):
                    Console.Clear();

                    _sellerMenu.Initialize();
                    Initialize();
                    break;

                case (2):
                    Console.Clear();
                    _companyMenu.Initialize();
                    Initialize();
                    break;

                case (3):
                    Console.Clear();
                    _productMenu.Initialize();
                    Initialize();
                    break;

                case (4):
                    Console.Clear();
                    _orderMenu.Initialize();
                    Initialize();
                    break;

                case (0):
                    break;

                default:
                    Console.WriteLine("Wybrałeś nieistniejącą opcję.");
                    MenuSwitch();
                    break;
            }
        }

 
    }
}
