using DAL.DAO;
using System.Collections.Generic;
using DAL.CQRS.Queries;

namespace DAL.CQRS.QueryHandlers
{
    public class GetAttributesQueryHandler : IQueryHandler<GetAttributesQuery, IEnumerable<Attribute>>
    {
        private AttributeContext Context { get; }

        public GetAttributesQueryHandler(AttributeContext context)
        {
            Context = context;
        }

        public IEnumerable<Attribute> Handle(GetAttributesQuery query)
        {
            return Context.Attributes;
        }
    }
}
