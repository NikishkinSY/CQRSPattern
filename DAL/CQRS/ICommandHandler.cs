using System.Threading.Tasks;

namespace DAL.CQRS
{
    public interface ICommandHandler<in T> where T : ICommand
    {
        Task Handle(T command);
    }
}
