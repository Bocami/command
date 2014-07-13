namespace Bocami.Practices.Command
{
    /// <summary>
    /// A CommandHandler handles a Command.
    /// </summary>
    /// <typeparam name="TCommand"></typeparam>
    public interface ICommandHandler<in TCommand> 
        where TCommand : ICommand
    {
        void Handle(TCommand command);
    }
}
