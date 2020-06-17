using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Models
{
    public class CompanyModel
    {   
        public int Id { get; set; }
        // Nazwa firmy
        public string Name { get; set; }
        // Lokalizacja: Kraj i adres
        public string Country { get; set; }
        public string Adress { get; set; }
    }
}
