using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GestionProduit.Infrastuctures
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private IDatabaseFactory _dbFactory;
        DbSet<T> dbset { get { return _dbFactory.DataContext.Set<T>(); } }
        public RepositoryBase(IDatabaseFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public void Add(T entity)
        {
            dbset.Add(entity);
        }

        public void Delete(T entity)
        {
            dbset.Remove(entity);
        }

        public void Delete(Expression<Func<T, bool>> condition)
        {
            dbset.RemoveRange(dbset.Where(condition));
        }

        public T Get(Expression<Func<T, bool>> condition)
        {
            return dbset.FirstOrDefault(condition);
        }

        public IEnumerable<T> GetAll()
        {
            return dbset.AsEnumerable();
        }

        public T GetById(long id)
        {
            return dbset.Find(id);
        }

        public T GetById(string id)
        {
            return dbset.Find(id);
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> condition)
        {
            if (condition != null)
                return dbset.Where(condition).AsEnumerable();
            return dbset.AsEnumerable();
        }

        public void Update(T entity)
        {
            dbset.Update(entity);
        }

    }
}