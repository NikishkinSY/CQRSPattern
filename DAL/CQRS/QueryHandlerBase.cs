using System;

namespace DAL.CQRS
{
    public abstract class QueryHandlerBase<TQuery, TResult>: HandlerBase, IQueryHandler<TQuery, TResult> where TQuery : IQuery
    {
        public TResult Process(TQuery query)
        {
            try
            {
                return Handle(query);              
            }
            catch (Exception ex)
            {
                // log
                return default(TResult);
            }
        }

        public abstract TResult Handle(TQuery query);
    }
}
