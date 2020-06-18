using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Models
{
    public class SellerModel
    {
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int CompanyId { get; set; }
        
        public string FullName
        {
            get { return $"{ FirstName } { LastName }"; }
        }
    }
}
