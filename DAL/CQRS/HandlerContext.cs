namespace DAL.CQRS
{
    public class HandlerContext
    {
        public IUnitOfWork UnitOfWork { get; set; }
        public HandlerBuilder HandlerBuilder { get; set; }

        public HandlerContext(IUnitOfWork unitOfWork, HandlerBuilder handlerBuilder)
        {
            this.UnitOfWork = unitOfWork;
            this.HandlerBuilder = handlerBuilder;
        }
    }
}
