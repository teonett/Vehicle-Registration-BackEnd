using BE_Vehicle.Shared.Commands.Contracts;

namespace BE_Vehicle.Shared.Handlers.Contracts
{
     public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}