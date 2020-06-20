using App.Library.Data.Dtos;
using App.Library.Interfaces;
using App.Library.Interfaces.Repository;
using App.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Library.Data.DataAccess
{
    public class OrderedProductRepository : IOrderedProductRepository
    {
        private readonly IDatabase _database;

        public OrderedProductRepository(IDatabase database)
        {
            _database = database;
        }
        public void Create(int orderId, int productId, decimal quantity)
        {
            var id = _database.OrderedProducts.Count > 0 ? _database.OrderedProducts.Last().Id + 1 : 0;

            var orderedProduct = new OrderedProductModel
            {
                Id = id,
                OrderId = orderId,
                ProductId = productId,
                Quantity = quantity
            };

            _database.OrderedProducts.Add(orderedProduct);

        }

        public List<OrderedProductDto> Get(int orderId)
        {
            var orderedProducts = _database.OrderedProducts.Where(x => x.OrderId == orderId);

            var orderedProductsDto = new List<OrderedProductDto>();

            foreach (var orderedProduct in orderedProducts)
            {
                var product = _database.Products.FirstOrDefault(x => x.Id == orderedProduct.ProductId);

                var orderedProductDto = new OrderedProductDto
                {
                    Name = product.Name,
                    Quantity = orderedProduct.Quantity,
                    Price = orderedProduct.Quantity * product.PricePerKg
                };

                orderedProductsDto.Add(orderedProductDto);
            }

            return orderedProductsDto;
        }
    }
}
