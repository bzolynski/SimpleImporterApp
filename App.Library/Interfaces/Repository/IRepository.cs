using App.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Interfaces.Repository
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T Get(int id);
        void Delete(int id);
    }
}
