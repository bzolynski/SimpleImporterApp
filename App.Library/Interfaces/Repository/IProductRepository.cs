using App.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Interfaces.Repository
{
    public interface IProductRepository : IRepository<ProductModel>
    {
        void Create(string name, decimal pricePerKg);
    }
}
