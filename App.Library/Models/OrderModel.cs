using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public double Quantity { get; set; }
        public int ProductId { get; set; }
        public int SellerId { get; set; }
    }
}
