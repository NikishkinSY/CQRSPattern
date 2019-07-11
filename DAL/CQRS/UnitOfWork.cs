namespace DAL.CQRS
{
    public class UnitOfWork: IUnitOfWork
    {
        public AttributeContext Context { get; set; }

        public UnitOfWork(AttributeContext Context)
        {
            this.Context = Context;
        }

        public void Commit()
        {
            Context.SaveChanges();
        }
    }
}
