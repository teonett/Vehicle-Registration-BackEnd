using System;
using System.Collections.Generic;
using BE_Vehicle.Domain.Entities;

namespace BE_Vehicle.Domain.Repositories
{
    public interface IVehicleRepository
    {
         IEnumerable<Vehicle> GetAll();
         Vehicle GetById(int id);
         void Add(Vehicle entity);
         void Update(Vehicle entity);
        void Remove(Vehicle entity);
    }
}