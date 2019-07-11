using System;

namespace DAL.CQRS
{
    public abstract class CommandHandlerBase<TCommand> : HandlerBase, ICommandHandler<TCommand> where TCommand: ICommand
    {
        public int Process(TCommand command)
        {
            try
            {
                Handle(command);
                return Context.SaveChanges();
            }
            catch (Exception ex)
            {
                // log
                return default(int);
            }
        }

        public abstract void Handle(TCommand command);
    }
}
