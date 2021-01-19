using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BE_Vehicle.Shared.Entities;

namespace BE_Vehicle.Domain.Entities
{
    public class Category : BaseEntity
    {
        public Category()
        {
            //this.Vehicles = new List<Vehicle>();
        }
        public Category(string description)
        {
            Description = description;
            LastUpdateDate = DateTime.Now;
        }

        [StringLength(5)]
        public string Description { get; private set; }

        [DataType(DataType.Date)]
        public DateTime LastUpdateDate { get; private set; }

        [NotMapped]
        public ICollection<Vehicle> Vehicles { get; set; }
        
        public void UpdateDescription(string description)
        {
            Description = description.ToUpper().Trim();
            LastUpdateDate = DateTime.Now;
        }

    }
}