namespace DAL.CQRS
{
    public interface IHandler
    {
        AttributeContext Context { get; set; }
        void InitializeContext(AttributeContext context, HandlerBuilder handlerBuilder);
        THandler GetHandler<THandler>() where THandler : class, IHandler;
    }
}
