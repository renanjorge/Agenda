using System.Collections.Generic;
using NHibernate;

namespace Agenda.Domain.Interfaces.Repository 
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Save(TEntity entity);
        TEntity FindById(int id);
        IEnumerable<TEntity> FindAll();
        void Update(TEntity entity);
        void Delete(int id);
        ITransaction BeginTransaction();       
    }
}
