using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Data.Dtos
{
    /// <summary>
    /// Data transfer object dla zamówień
    /// </summary>
    public class OrderDto
    {
        public int Id { get; set; }
        public string SellerName { get; set; }
        public string OrderDate { get; set; }

    }
}
