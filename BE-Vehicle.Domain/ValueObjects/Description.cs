using BE_Vehicle.Shared.ValueObjects;
using Flunt.Validations;

namespace BE_Vehicle.Domain.ValueObjects
{
    public class Description : ValueObject
    {
        
        public Description(string name)
        {
            Name = name;
            
             AddNotifications(new Contract()
                .Requires()
                .IsTrue(Validate(), "Description.Name", "Invalid description.")
            );
        }

        public string Name { get; private set; }
        
        private bool Validate()
        {
            return false;
        }
        
    }
}