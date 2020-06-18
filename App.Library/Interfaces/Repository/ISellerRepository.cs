using App.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Interfaces.Repository
{
    public interface ISellerRepository : IRepository<SellerModel>
    {
        void Create(string firstName, string lastName, string email, int companyId);
    }
}
