namespace DAL.CQRS
{
    public interface IQueryHandler<in T, out TResponse> where T : IQuery
    {
        TResponse Handle(T query);
    }
}
