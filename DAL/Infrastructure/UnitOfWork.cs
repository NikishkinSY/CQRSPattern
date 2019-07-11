using Microsoft.EntityFrameworkCore;

namespace DAL.CQRS
{
    public class UnitOfWork: IUnitOfWork
    {
        public AttributeContext DbContext { get; set; }

        public UnitOfWork(AttributeContext Context)
        {
            this.DbContext = Context;
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
