using App.Library.Interfaces;
using App.Library.Interfaces.Repository;
using App.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Library.Data.DataAccess
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly IDatabase _database;

        public CompanyRepository(IDatabase database)
        {
            _database = database;
        }

        public void Create(string name, string country, string adress)
        {

            var id = _database.Companies.Count > 0 ? _database.Companies.Last().Id + 1 : 0;

            var company = new CompanyModel
            {
                Id = id,
                Name = name,
                Country = country,
                Adress = adress
            };

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
