using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        // Nazwa produktu
        public string Name { get; set; }
        // Cena za kilogram produktu
        public double PricePerKg { get; set; }
    }
}
