using App.Library.Data.Dtos;
using App.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.UI.Interfaces
{
    public interface IPrintTables
    {
        void SellersTable();
        void CompaniesTable();
        void OrdersTable();
        void ProductsTable();
        void OrderDetailsTable(int id);
    }
}
