using App.Library.Interfaces;
using App.Library.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace App.Library.Data.DataAccess
{
    public class SellerRepository : IRepository<SellerModel>
    {
        private readonly IDatabase _database;

        public SellerRepository(IDatabase database)
        {
            _database = database;
        }

        public void Create(SellerModel seller)
        {
            _database.Sellers.Add(seller);
        }

        public List<SellerModel> GetAll()
        {
            return _database.Sellers;
        }

        public SellerModel Get(int id)
        {
            return _database.Sellers.FirstOrDefault(x => x.Id == id);
        }

        public void Delete(int id)
        {
            _database.Sellers.Remove(_database.Sellers.FirstOrDefault(x => x.Id == id));
        }


    }
}
