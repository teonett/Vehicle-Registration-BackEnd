using BE_Vehicle.Domain.Commands;
using BE_Vehicle.Domain.Entities;
using BE_Vehicle.Domain.Repositories;
using BE_Vehicle.Shared.Commands.Contracts;
using BE_Vehicle.Shared.Handlers.Contracts;
using Flunt.Notifications;

namespace BE_Vehicle.Domain.Handlers
{
    public class CategoryHandler : 
        Notifiable, 
        IHandler<CreateCategoryCommand>,
        IHandler<UpdateCategoryCommand>
    {
        private readonly ICategoryRepository _repository;

        public CategoryHandler()
        {
            
        }

        public CategoryHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateCategoryCommand command)
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

            var category = new Category(command.Description);
            _repository.Add(category);

            return new GenericCommandResult(true, "Saved successfully.", category);
        }

        public ICommandResult Handle(UpdateCategoryCommand command)
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

            var category = new Category(command.Description);
            _repository.Update(category);

            return new GenericCommandResult(true, "Saved successfully.", category);
        }
    }
}