using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Models
{
    /// <summary>
    /// Model dla zamówionych produktów
    /// </summary>
    public class OrderedProductModel
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
    }
}
