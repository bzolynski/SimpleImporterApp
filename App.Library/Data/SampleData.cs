using App.Library.Interfaces;
using App.Library.Models;
using System.Collections.Generic;

namespace App.Library.Data
{
    /// <summary>
    /// Ta klasa inicjalizuje przykładowe dane do "bazy"
    /// </summary>
    public class SampleData : ISampleData
    {
        private readonly IDatabase _database;

        public SampleData(IDatabase database)
        {
            _database = database;
        }

        public void Initialize()
        {
            PopulateSellers();
            PopulateCompanies();
            PopulateProducts();

            _database.Orders = new List<OrderModel>();
            _database.OrderedProducts = new List<OrderedProductModel>();

        }
        private void PopulateSellers()
        {
            List<SellerModel> sellers = new List<SellerModel>
            {
                new SellerModel
                {
                    Id = 0,
                    FirstName = "Carla",
                    LastName = "Frank",
                    Email = "carla.frank@gmail.com",
                    CompanyId = 2
                },
                new SellerModel
                {
                     Id = 1,
                     FirstName = "Tom",
                     LastName = "Smith",
                     Email = "tom.smith@gmail.com",
                     CompanyId = 0
                },
                new SellerModel
                {
                    Id = 2,
                    FirstName = "Bob",
                    LastName = "Long",
                    Email = "bob.long@gmail.com",
                    CompanyId = 1
                },
                new SellerModel
                {
                    Id = 3,
                    FirstName = "Gabierlla",
                    LastName = "Stracciatella",
                    Email = "gabierlla.stracciatella@gmail.com",
                    CompanyId = 1
                },
                new SellerModel
                {
                    Id = 4,
                    FirstName = "Guseppe",
                    LastName = "Cinque",
                    Email = "guseppe.cinque@gmail.com",
                    CompanyId = 0
                },
                
            };

            _database.Sellers = sellers;
        }

        private void PopulateCompanies()
        {
            List<CompanyModel> companies = new List<CompanyModel> 
            {
                new CompanyModel
                {
                    Id = 0,
                    Name = "Fruit Italy",
                    Country = "Włochy",
                    Adress = "Piazza Don Luigi Sturzo 18, Avellino"
                },
                new CompanyModel
                {
                    Id = 1,
                    Name = "Apple&PearCo",
                    Country = "Polska",
                    Adress = "Krakowska 45, Krakow"
                },
                new CompanyModel
                {
                    Id = 2,
                    Name = "Edo Fruit",
                    Country = "Niderlandy",
                    Adress = "Tinbergenlaan 48, Zwolle"
                },
                
            };

            _database.Companies = companies;
        }

        private void PopulateProducts()
        {
            List<ProductModel> products = new List<ProductModel>
            {
                new ProductModel
                {
                    Id = 0,
                    Name = "Arbuz",
                    PricePerKg = 3.99M
                },
                new ProductModel
                {
                    Id = 1,
                    Name = "Pomarańcza",
                    PricePerKg = 12.3M
                },
                new ProductModel
                {
                    Id = 2,
                    Name = "Truskawka",
                    PricePerKg = 6.55M
                },
                new ProductModel
                {
                    Id = 3,
                    Name = "Jabłko",
                    PricePerKg = 21.37M
                },
                new ProductModel
                {
                    Id = 4,
                    Name = "Ziemniak",
                    PricePerKg = 1.95M
                },
                new ProductModel
                {
                    Id = 5,
                    Name = "Winogrono",
                    PricePerKg = 13.09M
                },
                

            };

            _database.Products = products;
        }
    }
}
