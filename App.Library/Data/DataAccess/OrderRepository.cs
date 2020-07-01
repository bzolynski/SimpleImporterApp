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
    /// <summary>
    /// Repository do zarządzania zamównieniami
    /// </summary>
    public class OrderRepository : IOrderRepository
    {
        private readonly IDatabase _database;

        public OrderRepository(IDatabase database)
        {
            _database = database;
        }
        /// <summary>
        /// Tworzy nowe zamówienie
        /// </summary>
        /// <param name="sellerId"> ID sprzedawcy </param>
        /// <returns> Zwraca id nowo powstałego zamówienia </returns>
        public int Create(int sellerId)
        {

            var id = _database.Orders.Count > 0 ? _database.Orders.Last().Id + 1 : 0;

            var order = new OrderModel
            {
                Id = id,
                SellerId = sellerId
            };

            _database.Orders.Add(order);
            return id;
        }

        /// <summary>
        /// Zwraca wszystkie zamówienia
        /// </summary>
        /// <returns> Zamówienia </returns>
        public List<OrderDto> GetAll()
        {

            var orders = _database.Orders;

            var orderDtoList = new List<OrderDto>();

            if (orders.Count > 0)
            {
                foreach (var order in orders)
                {
                    var seller = _database.Sellers.FirstOrDefault(x => x.Id == order.SellerId);
                    
                    var orderDto = new OrderDto
                    {
                        Id = order.Id,
                        OrderDate = order.OrderDate,
                        SellerName = seller != null ? seller.FullName : "DELETED",
                    };

                    orderDtoList.Add(orderDto);
                }
            }
            

            return orderDtoList;
        }

        public OrderDto Get(int id)
        {
            throw new Exception();

        }

        /// <summary>
        /// Usuwa zamówienie
        /// </summary>
        /// <param name="id"> Id zamówienia do usunięcia </param>
        public void Delete(int id)
        {
            _database.Orders.Remove(_database.Orders.FirstOrDefault(x => x.Id == id));
            _database.OrderedProducts.RemoveAll(x => x.OrderId == id);
        }

        
    }
}
