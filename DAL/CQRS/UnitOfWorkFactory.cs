namespace DAL.CQRS
{
    public class UnitOfWorkFactory
    {
        private AttributeContext _context;
        public UnitOfWorkFactory(AttributeContext context)
        {
            _context = context;
        }

        public IUnitOfWork CreateUnitOfWork()
        {
            return new UnitOfWork(_context);
        }
    }
}
