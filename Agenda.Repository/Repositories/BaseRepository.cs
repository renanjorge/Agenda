using System;
using System.Collections.Generic;
using System.Linq;
using Agenda.Domain.Interfaces.Repository;
using NHibernate;

namespace Agenda.Repository.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly ISession session;

        public BaseRepository(ISession session) 
        {
            this.session = session;
        }

        public virtual IEnumerable<TEntity> FindAll()
        {
            var entities = session.Query<TEntity>().ToList();
            return entities;
        }

        public virtual TEntity FindById(int id)
        {
            var entities = session.Get<TEntity>(id);
            return entities;
        }

        public virtual void Save(TEntity entity)
        {
            using(var transaction = session.BeginTransaction())
            {
                try 
                {
                    session.Save(entity);
                    transaction.Commit();
                } catch(Exception ex)
                {
                    transaction.Rollback();
                    throw new System.ArgumentException(ex.Message);
                }
            } 
        }

        public virtual void Update(TEntity entity)
        {
            using(var transaction = session.BeginTransaction())
            {
                try 
                {
                    session.Update(entity);
                    transaction.Commit();
                } catch(Exception ex)
                {
                    transaction.Rollback();
                    throw new System.ArgumentException(ex.Message);
                }
            } 
        }
        
        public virtual void Delete(int id)
        {
            using(var transaction = session.BeginTransaction())
            {      
                try 
                {
                    session.CreateQuery($@"delete {typeof(TEntity)} where id = {id}")
                       .ExecuteUpdate();

                    transaction.Commit();
                } catch(Exception ex)
                {
                    transaction.Rollback();
                    throw new System.ArgumentException(ex.Message);
                }  
            } 
        }

        public ITransaction BeginTransaction() => session.BeginTransaction();
    }
}