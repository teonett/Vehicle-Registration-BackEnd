using System.Collections.Generic;
using System.Linq;
using BE_Vehicle.Domain.Entities;
using BE_Vehicle.Domain.Repositories;
using BE_Vehicle.Infra.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BE_Vehicle.Infra.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationContext _context;

        public CategoryRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Add(Category entity)
        {
            _context.Categories.Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Categories
               .AsNoTracking();
        }

        public Category GetById(int id)
        {
            return _context.Categories
                .FirstOrDefault(x => x.Id == id);
        }

        public void Remove(Category entity)
        {
             _context.Categories.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Category entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
        
    }
}