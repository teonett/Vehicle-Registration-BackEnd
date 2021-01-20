using System;
using System.Collections.Generic;
using BE_Vehicle.Domain.Entities;

namespace BE_Vehicle.Domain.Repositories
{
    public interface ICategoryRepository 
    {
         IEnumerable<Category> GetAll();
         Category GetById(int id);
         void Add(Category entity);
         void Update(Category entity);
          void Remove(Category entity);
    }
}