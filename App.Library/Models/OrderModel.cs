using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        // Ilość zamówionego produktu
        public double Quantity { get; set; }
        // Id produktów
        public List<int> ProductIds { get; set; }
        // Id sprzedawcy
        public int SellerId { get; set; }
    }
}
