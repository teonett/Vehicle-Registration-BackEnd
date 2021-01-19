using System;
using System.Collections.Generic;
using BE_Vehicle.Domain.Entities;
using BE_Vehicle.Domain.Repositories;

namespace BE_Vehicle.Test.Repositories
{
    public class FakeCategoryRepository : ICategoryRepository
    {
        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(Guid id)
        {
            return new Category("ZZZ");
        }

       

        public void Add(Category entity)
        {
            
        }

        public void Update(Category entity)
        {
            
        }

         public void Remove(Category entity)
        {
            
        }
    }
}