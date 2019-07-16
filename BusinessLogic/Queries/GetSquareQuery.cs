using DAL.CQRS;

namespace BusinessLogic.Queries
{
    public class GetSquareQuery: IQuery
    {
        public GetSquareQuery(int a, int b)
        {
            this.A = a;
            this.B = b;
        }

        public int A { get; set; }
        public int B { get; set; }
    }
}
