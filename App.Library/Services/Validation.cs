using App.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace App.Library.Services
{
    /// <summary>
    /// Prosty serwis do walidacji danych
    /// </summary>
    public class Validation : IValidation
    {
        private readonly IDatabase _database;

        public Validation(IDatabase database)
        {
            _database = database;
        }

        /// <summary>
        /// Sprawdza czay dana firma istnieje w bazie danych 
        /// </summary>
        /// <param name="id"> Id firmy</param>
        /// <returns> True jeśli istnieje / false jeśli nie </returns>
        public bool DoesCompanyExist(int id)
        {
            bool result = false;

            if (_database.Companies.Exists(x => x.Id == id))
            {
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Sprawdza czay dany sprzedawca istnieje w bazie danych 
        /// </summary>
        /// <param name="id"> Id sprzedawcy</param>
        /// <returns> True jeśli istnieje / false jeśli nie </returns>
        public bool DoesSellerExist(int id)
        {
            bool result = false;

            if (_database.Sellers.Exists(x => x.Id == id))
            {
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Sprawdza czay dany produkt istnieje w bazie danych 
        /// </summary>
        /// <param name="id"> Id produktu</param>
        /// <returns> True jeśli istnieje / false jeśli nie </returns>
        public bool DoesProductExist(int id)
        {
            bool result = false;

            if (_database.Products.Exists(x => x.Id == id))
            {
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Sprawdza czay dane zamówienie istnieje w bazie danych 
        /// </summary>
        /// <param name="id"> Id zamówienia</param>
        /// <returns> True jeśli istnieje / false jeśli nie </returns>
        public bool DoesOrderExist(int id)
        {
            bool result = false;

            if (_database.Orders.Exists(x => x.Id == id))
            {
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Sprawdza czy podany adres email jest prawidłowy
        /// </summary>
        /// <param name="email"> Adres email </param>
        /// <returns> True jeśli poprawny / false jeśli nie </returns>
        public bool IsValidEmail(string email)
        {
            var regex = new Regex(@"^([a-zA-Z0-9\.]+)@([a-zA-Z]+)\.([a-zA-Z]{2,})$");

            if (regex.IsMatch(email))
            {
                return true;
            }

            Console.WriteLine("Podaj właściwy adres email.");
            return false;
        }
    }
}
