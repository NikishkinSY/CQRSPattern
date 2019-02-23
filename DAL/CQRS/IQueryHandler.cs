using System.Threading.Tasks;

namespace DAL.CQRS
{
    public interface IQueryHandler<in T, TResponse> where T : IQuery<TResponse>
    {
        Task<TResponse> Handle(T query);
    }
}
