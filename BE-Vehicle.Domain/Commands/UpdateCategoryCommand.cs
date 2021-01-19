using BE_Vehicle.Shared.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;

namespace BE_Vehicle.Domain.Commands
{
    public class UpdateCategoryCommand : Notifiable, ICommand
    {
        public string Description { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Description, 2, "Description", "The Category field must contain between 2 and 5 characters.")
                .HasMaxLen(Description, 5, "Description", "The Category field must contain between 2 and 5 characters.")                
            );
        }
    }
}