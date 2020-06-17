using App.Library.Interfaces;
using App.Library.Models;
using System.Collections.Generic;

namespace App.Library.Data
{
    public class SampleData : ISampleData
    {
        private readonly IDatabase _database;

        public SampleData(IDatabase database)
        {
            _database = database;
        }
        public void PopulateSellers()
        {
            List<SellerModel> sellers = new List<SellerModel>
            {
                new SellerModel
                {
                     Id = 1,
                     FirstName = "Tom",
                     LastName = "Smith",
                     Email = "tom.smith@gmail.com",
                     CompanyId = 1
                },
                new SellerModel
                {
                    Id = 2,
                    FirstName = "Bob",
                    LastName = "Long",
                    Email = "bob.long@gmail.com",
                    CompanyId = 2
                },
                new SellerModel
                {
                    Id = 3,
                    FirstName = "Gabierlla",
                    LastName = "Stracciatella",
                    Email = "gabierlla.stracciatella@gmail.com",
                    CompanyId = 2
                },
                new SellerModel
                {
                    Id = 4,
                    FirstName = "Guseppe",
                    LastName = "Cinque",
                    Email = "guseppe.cinque@gmail.com",
                    CompanyId = 1
                },
                new SellerModel
                {
                    Id = 5,
                    FirstName = "Carla",
                    LastName = "Frank",
                    Email = "carla.frank@gmail.com",
                    CompanyId = 3
                }
            };

            _database.Sellers = sellers;
        }

        public void PopulateCompanies()
        {
            List<CompanyModel> companies = new List<CompanyModel> 
            { 
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
                new CompanyModel
                {
                    Id = 3,
                    Name = "Fruit Italy",
                    Country = "Włochy",
                    Adress = "Piazza Don Luigi Sturzo 18, Avellino"
                }
            };

            _database.Companies = companies;
        }

        public void PopulateProducts()
        {
            List<ProductModel> products = new List<ProductModel>
            {
                new ProductModel
                {
                    Id = 1,
                    Name = "Pomarańcza",
                    PricePerKg = 12.3
                },
                new ProductModel
                {
                    Id = 2,
                    Name = "Truskawka",
                    PricePerKg = 6.55
                },
                new ProductModel
                {
                    Id = 3,
                    Name = "Jabłko",
                    PricePerKg = 21.37
                },
                new ProductModel
                {
                    Id = 4,
                    Name = "Ziemniak",
                    PricePerKg = 1.95
                },
                new ProductModel
                {
                    Id = 5,
                    Name = "Winogrono",
                    PricePerKg = 13.09
                },
                new ProductModel
                {
                    Id = 6,
                    Name = "Arbuz",
                    PricePerKg = 3.99
                }

            };

            _database.Products = products;
        }
    }
}
