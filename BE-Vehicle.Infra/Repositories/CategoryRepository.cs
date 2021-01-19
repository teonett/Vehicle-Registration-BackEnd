using System;
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

        public List<Category> GetAll()
        {
            return _context.Categories
            .AsNoTracking()
            .ToList();
        }

        public Category GetById(Guid id)
        {
            return _context.Categories
            .AsNoTracking()
            .FirstOrDefault(x => x.Id == id);
        }


        public void Add(Category entity)
        {
            _context.Categories.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Category entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void Remove(Category entity)
        {
            _context.Categories.Remove(entity);
            _context.SaveChanges();
        }
    }
}