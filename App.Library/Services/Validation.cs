using App.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace App.Library.Services
{
    public class Validation : IValidation
    {
        private readonly IDatabase _database;

        public Validation(IDatabase database)
        {
            _database = database;
        }

        public bool DoesCompanyExist(int id)
        {
            bool result = false;

            if (_database.Companies.Exists(x => x.Id == id))
            {
                result = true;
            }

            return result;
        }

        public bool DoesSellerExist(int id)
        {
            bool result = false;

            if (_database.Sellers.Exists(x => x.Id == id))
            {
                result = true;
            }

            return result;
        }

        public bool DoesProductExist(int id)
        {
            bool result = false;

            if (_database.Products.Exists(x => x.Id == id))
            {
                result = true;
            }

            return result;
        }

        public bool DoesOrderExist(int id)
        {
            bool result = false;

            if (_database.Orders.Exists(x => x.Id == id))
            {
                result = true;
            }

            return result;
        }

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
