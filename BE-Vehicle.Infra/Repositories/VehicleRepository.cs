using System;
using System.Collections.Generic;
using System.Linq;
using BE_Vehicle.Domain.Entities;
using BE_Vehicle.Domain.Repositories;
using BE_Vehicle.Infra.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BE_Vehicle.Infra.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly ApplicationContext _context;

        public VehicleRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Add(Vehicle entity)
        {
            _context.Vehicles.Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<Vehicle> GetAll()
        {
            return _context.Vehicles
               .AsNoTracking();
        }

        public Vehicle GetById(int id)
        {
            return _context.Vehicles
                .FirstOrDefault(x => x.Id == id);
        }

        public void Remove(Vehicle entity)
        {
             _context.Vehicles.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Vehicle entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

    }
}