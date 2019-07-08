using DAL.DAO;
using System.Collections.Generic;
using DAL.CQRS.Queries;

namespace DAL.CQRS.QueryHandlers
{
    public class GetAttributesQueryHandler : HandlerBase, IQueryHandler<GetAttributesQuery, IEnumerable<Attribute>>
    {
        public GetAttributesQueryHandler(AttributeContext context)
            :base(context)
        {
        }

        public IEnumerable<Attribute> Handle(GetAttributesQuery query)
        {
            return Context.Attributes;
        }
    }
}
