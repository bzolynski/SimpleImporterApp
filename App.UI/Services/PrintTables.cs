using App.Library.Data.Dtos;
using App.Library.Interfaces.Repository;
using App.Library.Models;
using App.UI.Interfaces;
using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.UI.Services
{
    /// <summary>
    /// Klasa zawierająca metody drukujące tabele dla poszczególnych danych. Do drukowania tabel użyty został NuGet - ConsoleTables. Link do GitHuba: https://github.com/khalidabuhakmeh/ConsoleTables
    /// </summary>
    public class PrintTables : IPrintTables
    {
        private readonly ISellerRepository _sellerRepository;
        private readonly ICompanyRepository _companyRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;
        private readonly IOrderedProductRepository _orderedProductRepository;

        public PrintTables(ISellerRepository sellerRepository, ICompanyRepository companyRepository, IOrderRepository orderRepository, IProductRepository productRepository, IOrderedProductRepository orderedProductRepository)
        {
            _sellerRepository = sellerRepository;
            _companyRepository = companyRepository;
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            _orderedProductRepository = orderedProductRepository;
        }
        public void SellersTable()
        {
            var sellers = _sellerRepository.GetAll();

            var sellersTable = new ConsoleTable("Id", "Full Name", "Email", "Company name");
            foreach (var sell in sellers)
            {
                sellersTable.AddRow(sell.Id, sell.FullName, sell.Email, sell.CompanyName);
            }
            sellersTable.Write();
            Console.WriteLine();
        }

        public int CompaniesTable()
        {
            var companies = _companyRepository.GetAll();

            var companiesTable = new ConsoleTable("Id", "Name", "Country", "Adress");
            foreach (var comp in companies)
            {
                companiesTable.AddRow(comp.Id, comp.Name, comp.Country, comp.Adress);
            }
            companiesTable.Write();
            Console.WriteLine();
            return companiesTable.Rows.Count;
        }

        public void OrdersTable()
        {
            var orders = _orderRepository.GetAll();

            var ordersTable = new ConsoleTable("Id", "Seller name", "Order date");
            foreach (var order in orders)
            {
                ordersTable.AddRow(order.Id, order.SellerName, order.OrderDate);
            }
            ordersTable.Write();
            Console.WriteLine();
        }
        public void OrderDetailsTable(int id)
        {
            var products = _orderedProductRepository.Get(id);

            var orderDetailsTable = new ConsoleTable("Product name", "Quantity", "Price");
            decimal total = 0.0M;
            foreach (var product in products)
            {
                if (product.Quantity > 0)
                {
                    total += product.Price * product.Quantity;
                    orderDetailsTable.AddRow(product.Name, product.Quantity.ToString() + " kg", product.Price.ToString("C"));
                }
            }
            orderDetailsTable.AddRow("", "Total: ", total.ToString("C"));
            orderDetailsTable.Write();
            Console.WriteLine();
        }

        public int ProductsTable()
        {
            var products = _productRepository.GetAll();

            var productsTable = new ConsoleTable("Id", "Name", "Price/kg");
            foreach (var prod in products)
            {
                productsTable.AddRow(prod.Id, prod.Name, prod.PricePerKg.ToString("C"));
            }
            productsTable.Write();
            Console.WriteLine();

            return productsTable.Rows.Count;
        }
    }
}
