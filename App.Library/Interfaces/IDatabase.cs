using App.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Interfaces
{
    public interface IDatabase
    {
        List<CompanyModel> Companies { get; set; }
        List<OrderModel> Orders { get; set; }
        List<ProductModel> Products { get; set; }
        List<SellerModel> Sellers { get; set; }
        List<OrderedProductModel> OrderedProducts { get; set; }
    }
}
