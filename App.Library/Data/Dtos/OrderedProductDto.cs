using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Data.Dtos
{
    public class OrderedProductDto
    {
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
