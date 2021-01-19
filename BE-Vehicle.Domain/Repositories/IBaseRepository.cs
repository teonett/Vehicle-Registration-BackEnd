using System;
using System.Collections.Generic;

namespace BE_Vehicle.Domain.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
         List<TEntity> GetAll();
         TEntity GetById(Guid id);
         void Add(TEntity entity);
         void Update(TEntity entity);
          void Remove(TEntity entity);
    }
}