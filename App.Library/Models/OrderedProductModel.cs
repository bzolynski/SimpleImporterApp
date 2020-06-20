using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Models
{
    public class OrderedProductModel
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
    }
}
