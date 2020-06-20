using App.Library.Data.Dtos;
using App.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Interfaces.Repository
{
    public interface ISellerRepository : IRepository<SellerDto>
    {
        void Create(string firstName, string lastName, string email, int companyId);
    }
}
