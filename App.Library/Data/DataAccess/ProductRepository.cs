using App.Library.Interfaces;
using App.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Library.Data.DataAccess
{
    public class ProductRepository : IRepository<ProductModel>
    {
        private readonly IDatabase _database;

        public ProductRepository(IDatabase database)
        {
            _database = database;
        }

        public void Create(ProductModel company)
        {
            _database.Products.Add(company);
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
        }
    }
}
