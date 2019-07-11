namespace DAL.CQRS
{
    public abstract class HandlerBase: IHandler
    {
        public AttributeContext Context { get; set; }
        private HandlerBuilder _handlerBuilder;

        public void InitializeContext(AttributeContext context, HandlerBuilder handlerBuilder)
        {
            Context = context;
            _handlerBuilder = handlerBuilder;
        }

        public THandler GetHandler<THandler>() where THandler: class, IHandler => _handlerBuilder.Build<THandler>();
    }
}
