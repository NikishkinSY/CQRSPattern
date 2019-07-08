namespace DAL.CQRS
{
    public abstract class HandlerBase
    {
        protected AttributeContext Context { get; }

        protected HandlerBase(AttributeContext context)
        {
            Context = context;
        }
    }
}
