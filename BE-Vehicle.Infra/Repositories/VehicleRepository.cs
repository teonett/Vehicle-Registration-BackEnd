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

        public List<Vehicle> GetAll()
        {
            return _context.Vehicles
                    .AsNoTracking()
                    .ToList();
        }

        public Vehicle GetById(Guid id)
        {
            return _context.Vehicles
                    .AsNoTracking()
                    .FirstOrDefault(x => x.Id == id);
        }

        public void Add(Vehicle entity)
        {
           _context.Vehicles.Add(entity);
           _context.SaveChanges();
        }

        public void Update(Vehicle entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Remove(Vehicle entity)
        {
            _context.Vehicles.Remove(entity);
            _context.SaveChanges();
        }

    }
}