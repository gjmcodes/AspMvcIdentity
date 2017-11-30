using System;
using System.Collections.Generic;
using Domain.Interfaces.Repositories;
using CrossCutting.Data.Context;
using System.Data.Entity;
using System.Linq;

namespace CrossCutting.Data.Repositories
{
    public class BaseRepository<TKey, TObj> : IBaseRepository<TKey, TObj>
        where TObj : class
    {
        protected readonly AppDbContext _db;
        protected readonly DbSet<TObj> _dbSet;

        public BaseRepository()
        {
            _db = new AppDbContext();
            _dbSet = _db.Set<TObj>();
        }


        public virtual IEnumerable<TObj> GetAll()
        {
            return _dbSet;
        }

        public virtual TObj GetById(TKey id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Dispose()
        {
            _db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
