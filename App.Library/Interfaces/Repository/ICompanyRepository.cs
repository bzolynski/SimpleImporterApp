using App.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Interfaces.Repository
{
    public interface ICompanyRepository : IRepository<CompanyModel>
    {
        void Create(string name, string country, string adress);
    }
}
