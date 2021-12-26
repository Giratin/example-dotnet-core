using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GestionProduit.Repositories
{
    public interface IService<T> where T : class
    {
        void Commit();
        void Dispose();
        void Add(T entity);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> condition);
        void Update(T entity);
        T Get(Expression<Func<T, bool>> condition);
        T GetById(long id);
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetMany(Expression<Func<T, bool>> condition);

    }
}