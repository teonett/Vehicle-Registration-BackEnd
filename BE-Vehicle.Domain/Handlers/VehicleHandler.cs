using BE_Vehicle.Domain.Commands;
using BE_Vehicle.Domain.Entities;
using BE_Vehicle.Domain.Repositories;
using BE_Vehicle.Shared.Commands.Contracts;
using BE_Vehicle.Shared.Handlers.Contracts;
using Flunt.Notifications;

namespace BE_Vehicle.Domain.Handlers
{
    public class VehicleHandler :
        Notifiable,
        IHandler<CreateVehicleCommand>,
        IHandler<UpdateVehicleCommand>
    {
        private readonly IVehicleRepository _repository;

        public VehicleHandler()
        {
            
        }

        public VehicleHandler(IVehicleRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateVehicleCommand command)
        {
            command.Validate();
            if (!command.Valid)
            {
                return new GenericCommandResult(
                    false, 
                    "Whoops, looks like something went wrong.",
                    command.Notifications
                );
            }

            var vehicle = new Vehicle(command.Description, command.YearBuild, command.YearCategory, command.CategoryId);
            _repository.Update(vehicle);

            return new GenericCommandResult(true, "Saved successfully.", vehicle);
        }

        public ICommandResult Handle(UpdateVehicleCommand command)
        {
            command.Validate();
            if (!command.Valid)
            {
                return new GenericCommandResult(
                    false, 
                    "Whoops, looks like something went wrong.",
                    command.Notifications
                );
            }

            var vehicle = new Vehicle(command.Description, command.YearBuild, command.YearCategory, command.CategoryId);
            _repository.Update(vehicle);

            return new GenericCommandResult(true, "Saved successfully.", vehicle);
        }
    }
}