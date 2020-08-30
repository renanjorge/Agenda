using System.Collections.Generic;
using System.Linq;
using Agenda.Domain.Interfaces;
using NHibernate;

namespace Agenda.Repository.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly ISession Session;

        public BaseRepository(ISession session) 
        {
            Session = session;
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Session.Query<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Save(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose() 
        {
            throw new System.NotImplementedException();
        }
    }
}