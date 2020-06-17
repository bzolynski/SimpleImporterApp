using App.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Library.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Create(T company);
        List<T> GetAll();
        T Get(int id);
        void Delete(int id);
    }
}
