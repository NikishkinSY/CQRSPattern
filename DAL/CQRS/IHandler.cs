namespace DAL.CQRS
{
    public interface IHandler
    {
        HandlerContext Context { get; set; }
        void InitializeContext(HandlerContext context);
        THandler GetHandler<THandler>() where THandler : class, IHandler;
    }
}
