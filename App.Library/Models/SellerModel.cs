using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Models
{
    /// <summary>
    /// Model dla sprzedawcy
    /// </summary>
    public class SellerModel
    {        
        public int Id { get; set; }
        public string FirstName { private get; set; }
        public string LastName { private get; set; }
        public string Email { get; set; }
        public int CompanyId { get; set; }
        
        public string FullName
        {
            get { return $"{ FirstName.Trim() } { LastName.Trim() }"; }
        }
    }
}
