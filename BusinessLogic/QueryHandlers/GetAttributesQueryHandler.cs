using DAL.DAO;
using System.Collections.Generic;
using DAL.CQRS.Queries;

namespace DAL.CQRS.QueryHandlers
{
    public class GetAttributesQueryHandler : QueryHandlerBase<GetAttributesQuery, IEnumerable<Attribute>>
    {
        public override IEnumerable<Attribute> Handle(GetAttributesQuery query)
        {
            return Context.UnitOfWork.DbContext.Attributes;
        }
    }
}
