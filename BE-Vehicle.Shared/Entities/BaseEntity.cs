using System;
using System.ComponentModel.DataAnnotations;
using Flunt.Notifications;

namespace BE_Vehicle.Shared.Entities
{
    public abstract class BaseEntity : Notifiable,  IEquatable<BaseEntity>
    {
        public BaseEntity()
        {
            
        }
        
        public BaseEntity(Guid id)
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; private set; }

        public bool Equals(BaseEntity other)
        {
            return Id == other.Id;
        }
    }
}