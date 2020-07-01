using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Models
{
    /// <summary>
    /// Model dla zamówień
    /// </summary>
    public class OrderModel
    {
        public int Id { get; set; }
        public int SellerId { get; set; }
        public string OrderDate
        {
            get { return DateTime.Now.ToShortDateString(); }
        }

    }
}
