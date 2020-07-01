using App.Library.Interfaces;
using App.Library.Interfaces.Repository;
using App.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Library.Data.DataAccess
{
    /// <summary>
    /// Repository do zarządzania firmami.
    /// </summary>
    public class CompanyRepository : ICompanyRepository
    {
        private readonly IDatabase _database;

        public CompanyRepository(IDatabase database)
        {
            _database = database;
        }

        /// <summary>
        /// Dodawanie nowej firmy
        /// </summary>
        /// <param name="name"> Nazwa firmy </param>
        /// <param name="country"> Kraj w którym się znajduje </param>
        /// <param name="adress"> Adres siedziby </param>
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

        /// <summary>
        /// Zwraca listę firm
        /// </summary>
        /// <returns> Lista firm </returns>
        public List<CompanyModel> GetAll()
        {
            return _database.Companies;
        }

        /// <summary>
        /// Zwraca pojedynczą firmę
        /// </summary>
        /// <param name="id"> Id firmy do zwrócenia </param>
        /// <returns> Zwraca firmę </returns>
        public CompanyModel Get(int id)
        {
            return _database.Companies.FirstOrDefault(x => x.Id == id);
        }
        
        /// <summary>
        /// Usuwa firmę z wybranym id
        /// </summary>
        /// <param name="id"> Id firmy do usunięcia </param>
        public void Delete(int id)
        {
            _database.Companies.Remove(_database.Companies.FirstOrDefault(x => x.Id == id));
        }
    }
}
