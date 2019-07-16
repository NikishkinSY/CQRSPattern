using BusinessLogic.Queries;
using DAL.CQRS;

namespace BusinessLogic.QueryHandlers
{
    public class GetSquareQueryHandler: QueryHandlerBase<GetSquareQuery, int>
    {
        public override int Handle(GetSquareQuery query)
        {
            return query.A * query.B;
        }
    }
}
