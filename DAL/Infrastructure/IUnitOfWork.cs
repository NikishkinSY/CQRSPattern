using Microsoft.EntityFrameworkCore;

namespace DAL.CQRS
{
    public interface IUnitOfWork
    {
        AttributeContext DbContext { get; }
        void Commit();
    }
}
