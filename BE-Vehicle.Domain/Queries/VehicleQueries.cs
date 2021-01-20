using System;
using System.Linq.Expressions;
using BE_Vehicle.Domain.Entities;

namespace BE_Vehicle.Domain.Queries
{
    public static class VehicleQueries
    {
        public static Expression<Func<Vehicle, bool>> GetAll(int categoryId)
        {
            return x => x.CategoryId == categoryId;
        }
    }
}