using System.Collections.Generic;

namespace Agenda.Domain.Interfaces.Service 
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        void Save(TEntity entity);
        TEntity FindById(int id);
        IEnumerable<TEntity> FindAll();
        void Update(TEntity entity);
        void Delete(int id);
    }
}