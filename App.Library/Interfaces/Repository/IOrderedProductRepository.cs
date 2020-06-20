using App.Library.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Interfaces.Repository
{
    public interface IOrderedProductRepository
    {
        void Create(int orderId, int productId, decimal quantity);
        List<OrderedProductDto> Get(int orderId);
    }
}
