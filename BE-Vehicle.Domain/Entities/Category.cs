using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Vehicle.Domain.Entities
{
    [Table("Category")]
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
        public int Id { get; set; }
        
        [Required(ErrorMessage = "This field is required")]
        [StringLength(5)]
        [MaxLength(5, ErrorMessage = "The Category field must contain between 2 and 5 characters.")]
        [MinLength(2, ErrorMessage = "The Category field must contain between 2 and 5 characters.")]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastUpdateDate { get; private set; }

    }
}