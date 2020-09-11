using System.Collections.Generic;
using Agenda.Domain.Interfaces.Repository;
using Agenda.Domain.Interfaces.Service;

namespace Agenda.Domain.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity>  where TEntity : class
    {
        private readonly IBaseRepository<TEntity> baseRepository;

        public BaseService(IBaseRepository<TEntity> baseRepository) 
        {
            this.baseRepository = baseRepository;
        }

        public void Delete(int id)
        {
            this.baseRepository.Delete(id);
        }

        public IEnumerable<TEntity> FindAll()
        {
            return this.baseRepository.FindAll();
        }

        public TEntity FindById(int id)
        {
            return this.baseRepository.FindById(id);
        }

        public void Save(TEntity entity)
        {
            this.baseRepository.Save(entity);
        }

        public void Update(TEntity entity)
        {
            this.baseRepository.Update(entity);
        }
    }
}