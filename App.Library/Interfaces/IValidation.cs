using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Interfaces
{
    public interface IValidation
    {
        bool DoesCompanyExist(int id);
        bool DoesSellerExist(int id);
        bool DoesProductExist(int id);
        bool DoesOrderExist(int id);
        bool IsValidEmail(string email);

    }
}
