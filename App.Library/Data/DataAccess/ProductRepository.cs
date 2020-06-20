using App.Library.Interfaces;
using App.Library.Interfaces.Repository;
using App.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Library.Data.DataAccess
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDatabase _database;

        public ProductRepository(IDatabase database)
        {
            _database = database;
        }

        public void Create(string name, decimal pricePerKg)
        {
            var id = _database.Products.Count > 0 ? _database.Products.Last().Id + 1 : 0;

            var product = new ProductModel
            {
                Id = id,
                Name = name,
                PricePerKg = pricePerKg
            };
            _database.Products.Add(product);
        }

        public List<ProductModel> GetAll()
        {
            return _database.Products;
        }

        public ProductModel Get(int id)
        {
            return _database.Products.FirstOrDefault(x => x.Id == id);
        }

        public void Delete(int id)
        {
            _database.Products.Remove(_database.Products.FirstOrDefault(x => x.Id == id));

            _database.OrderedProducts.RemoveAll(x => x.ProductId == id);
            
        }
    }
}
