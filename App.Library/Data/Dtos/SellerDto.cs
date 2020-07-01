using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Data.Dtos
{
    /// <summary>
    /// Data transfer object dla sprzedawców
    /// </summary>
    public class SellerDto
    {
        public int Id { get; set; }        
        public string FullName { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        
    }
}
