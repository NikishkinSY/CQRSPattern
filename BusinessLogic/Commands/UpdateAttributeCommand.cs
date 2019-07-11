using DAL.CQRS;

namespace BusinessLogic.Commands
{
    public class UpdateAttributeCommand: ICommand
    {
        public int Id { get; private set; }
        public string NewName { get; private set; }
        public string NewDescription { get; private set; }

        public UpdateAttributeCommand(int id, string newName, string newDescription)
        {
            NewName = newName;
            NewDescription = newDescription;
            Id = id;
        }
    }
}
