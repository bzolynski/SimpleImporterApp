﻿using App.Library.Interfaces;
using App.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Data
{
    /// <summary>
    /// Przykładowa "baza danych"
    /// </summary>
    public class Database : IDatabase
    {
        public List<CompanyModel> Companies { get; set; }
        public List<ProductModel> Products { get; set; }
        public List<SellerModel> Sellers { get; set; }
        public List<OrderModel> Orders { get; set; } 
        public List<OrderedProductModel> OrderedProducts { get; set; }

    }
}
