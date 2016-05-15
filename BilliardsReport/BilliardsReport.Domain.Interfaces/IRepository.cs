using System;
using System.Collections.Generic;

namespace BilliardsReport.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T Get(int id);
        List<T> Find(Func<T, bool> predicate);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
    }
}
