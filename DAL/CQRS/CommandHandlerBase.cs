using System;

namespace DAL.CQRS
{
    public abstract class CommandHandlerBase<TCommand> : HandlerBase, ICommandHandler<TCommand> where TCommand: ICommand
    {
        public void Process(TCommand command)
        {
            try
            {
                Handle(command);
                Context.UnitOfWork.Commit();
            }
            catch (Exception ex)
            {
                // log
            }
        }

        public abstract void Handle(TCommand command);
    }
}
