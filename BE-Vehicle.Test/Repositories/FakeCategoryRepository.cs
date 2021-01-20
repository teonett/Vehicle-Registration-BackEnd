using System;
using System.Collections.Generic;
using BE_Vehicle.Domain.Entities;
using BE_Vehicle.Domain.Repositories;

namespace BE_Vehicle.Test.Repositories
{
    public class FakeCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
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