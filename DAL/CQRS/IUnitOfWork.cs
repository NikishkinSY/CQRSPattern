namespace DAL.CQRS
{
    public interface IUnitOfWork
    {
        AttributeContext Context { get; }
        void Commit();
    }
}
