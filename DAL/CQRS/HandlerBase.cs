namespace DAL.CQRS
{
    public abstract class HandlerBase: IHandler
    {
        public HandlerContext Context { get; set; }

        public void InitializeContext(HandlerContext context)
        {
            Context = context;
        }

        public THandler GetHandler<THandler>() where THandler: class, IHandler => Context.HandlerBuilder.Build<THandler>();
    }
}
