using System;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TKey, TObj> : IDisposable 
        where TObj : class
    {
        IEnumerable<TObj> GetAll();
        TObj GetById(TKey id);
    }
}
