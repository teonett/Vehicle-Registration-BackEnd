using System;
using System.ComponentModel.DataAnnotations;

namespace BE_Vehicle.Domain.Entities
{
    public class Category
    {
        public Category()
        {
            
        }
        
        public Category(string description)
        {
            Description = description;
            LastUpdateDate = DateTime.Now;
        }

        [Key]
        public int Id { get; private set; }

        [StringLength(5)]
        public string Description { get; private set; }

        [DataType(DataType.Date)]
        public DateTime LastUpdateDate { get; private set; }
        
        public void UpdateDescription(string description)
        {
            Description = description.ToUpper().Trim();
            LastUpdateDate = DateTime.Now;
        }

    }
}