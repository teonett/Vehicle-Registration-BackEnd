using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Vehicle.Domain.Entities
{
    [Table("Vehicle")]
    public class Vehicle
    {
        public Vehicle()
        {
            
        }
        public Vehicle(string description, int yearBuild, int yearCategory, int categoryId)
        {
            Description = description;
            YearBuild = ValidCurrentYearBuild(yearBuild);
            YearCategory = ValidRangeYearCategory(yearCategory);
            CategoryId = categoryId;
            LastUpdateDate = DateTime.Now;
        }

        [Key]
        public int Id { get; private set; }

        [StringLength(20)]
        [MaxLength(20, ErrorMessage = "The Category field must contain between 2 and 20 characters.")]
        [MinLength(2, ErrorMessage = "The Category field must contain between 2 and 20 characters.")]
        public string Description { get; private set; }

        [Required(ErrorMessage = "Year Build is required!")]        
        public int YearBuild { get; private set; }

        [Required(ErrorMessage = "Year Category is required!")]        
        public int YearCategory { get; private set; }
        public DateTime LastUpdateDate { get; private set; }

        [Required(ErrorMessage = "Category is required!")]
        public int CategoryId { get; private set; }
        public Category Category { get; private set; }

        private int ValidCurrentYearBuild(int yearBuild)
        {
            int validYear = yearBuild;

            if (yearBuild < DateTime.Now.Year || yearBuild > DateTime.Now.Year)
                validYear = DateTime.Now.Year;

            return validYear;
        }

        private int ValidRangeYearCategory(int yearCategory)
        {
            int validYear = yearCategory;

            if (yearCategory < DateTime.Now.Year || yearCategory > DateTime.Now.Year+2)
                validYear = DateTime.Now.Year;

            return validYear;
        }

    }
}