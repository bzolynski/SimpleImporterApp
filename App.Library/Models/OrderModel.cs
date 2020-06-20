using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        // Ilość zamówionego produktu        
        public int SellerId { get; set; }
        public string OrderDate
        {
            get { return DateTime.Now.ToShortDateString(); }
        }

    }
}
