using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using GestionProduit.Infrastuctures;

namespace GestionProduit.Repositories
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IUnitOfWork utk;

        public Service(IUnitOfWork utk)
        {
            this.utk = utk;
        }
        public void Add(T entity)
        {
            utk.getRepository<T>().Add(entity);
        }

        public virtual void Commit()
        {
            utk.Commit();
        }

        public virtual void Delete(T entity)
        {
            utk.getRepository<T>().Delete(entity);
        }

        public void Delete(Expression<Func<T, bool>> condition)
        {
            utk.getRepository<T>().Delete(condition);
        }

        public void Dispose()
        {
            utk.Dispose();
        }

        public T Get(Expression<Func<T, bool>> condition)
        {
            return utk.getRepository<T>().Get(condition);
        }

        public IEnumerable<T> GetAll()
        {
            return utk.getRepository<T>().GetAll();
        }

        public T GetById(long id)
        {
            return utk.getRepository<T>().GetById(id);
        }

        public T GetById(string id)
        {
            return utk.getRepository<T>().GetById(id);
        }

        public T GetById(int id)
        {
            return utk.getRepository<T>().GetById(id);
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> condition)
        {
            return utk.getRepository<T>().GetMany(condition);
        }

        public void Update(T entity)
        {
            utk.getRepository<T>().Update(entity);
        }
    }
}