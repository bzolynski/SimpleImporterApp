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
        int CompaniesTable();
        void OrdersTable();
        int ProductsTable();
        void OrderDetailsTable(int id);
    }
}
