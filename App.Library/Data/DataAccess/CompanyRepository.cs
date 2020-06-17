using App.Library.Interfaces;
using App.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Library.Data.DataAccess
{
    public class CompanyRepository : IRepository<CompanyModel>
    {
        private readonly IDatabase _database;

        public CompanyRepository(IDatabase database)
        {
            _database = database;
        }

        public void Create(CompanyModel company)
        {
            _database.Companies.Add(company);
        }

        public List<CompanyModel> GetAll()
        {
            return _database.Companies;
        }

        public CompanyModel Get(int id)
        {
            return _database.Companies.FirstOrDefault(x => x.Id == id);
        }
        
        public void Delete(int id)
        {
            _database.Companies.Remove(_database.Companies.FirstOrDefault(x => x.Id == id));
        }
    }
}
