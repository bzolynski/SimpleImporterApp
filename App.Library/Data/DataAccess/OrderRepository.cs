using App.Library.Interfaces;
using App.Library.Interfaces.Repository;
using App.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Library.Data.DataAccess
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IDatabase _database;

        public OrderRepository(IDatabase database)
        {
            _database = database;
        }

        public void Create(OrderModel company)
        {
            _database.Orders.Add(company);
        }

        public List<OrderModel> GetAll()
        {
            return _database.Orders;
        }

        public OrderModel Get(int id)
        {
            return _database.Orders.FirstOrDefault(x => x.Id == id);
        }

        public void Delete(int id)
        {
            _database.Orders.Remove(_database.Orders.FirstOrDefault(x => x.Id == id));
        }
    }
}
