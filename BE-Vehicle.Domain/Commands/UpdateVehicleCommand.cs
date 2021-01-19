using System;
using BE_Vehicle.Shared.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;

namespace BE_Vehicle.Domain.Commands
{
    public class UpdateVehicleCommand : Notifiable, ICommand
    {
        public UpdateVehicleCommand(string description, int yearBuild, int yearCategory, Guid categoryId)
        {
            Description = description;
            YearBuild = yearBuild;
            YearCategory = yearCategory;
            CategoryId = categoryId;
        }

        public string Description { get; set; }
        public int YearBuild { get; set; }
        public int YearCategory { get; set; }
        public Guid CategoryId { get; set; }
        
        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Description, 2, "Description", "The Category field must contain between 2 and 20 characters.")
                .HasMaxLen(Description, 20, "Description", "The Category field must contain between 2 and 20 characters.")
            );
        }
    }
}