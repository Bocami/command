namespace Bocami.Practices.Command
{
    /// <summary>
    /// Handles a Command by doing nothing.
    /// </summary>
    /// <typeparam name="TCommand">The type of Command</typeparam>
    public sealed class NullCommandHandler<TCommand> : ICommandHandler<TCommand>
        where TCommand : ICommand
    {
        public void Handle(TCommand command)
        {
        }
    }
}
