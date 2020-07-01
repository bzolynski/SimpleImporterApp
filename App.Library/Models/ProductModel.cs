using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Models
{
    /// <summary>
    /// Model dla produktu
    /// </summary>
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PricePerKg { get; set; }
    }
}
