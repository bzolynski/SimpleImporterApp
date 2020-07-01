using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Models
{
    /// <summary>
    /// Model dla firmy
    /// </summary>
    public class CompanyModel
    {   
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Adress { get; set; }
    }
}
