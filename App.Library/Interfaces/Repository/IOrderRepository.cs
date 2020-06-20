using App.Library.Data.Dtos;
using App.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Interfaces.Repository
{
    public interface IOrderRepository : IRepository<OrderDto>
    {
        int Create(int sellerId);
    }
}
