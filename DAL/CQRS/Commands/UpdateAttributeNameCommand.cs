namespace DAL.CQRS.Commands
{
    public class UpdateAttributeNameCommand: ICommand
    {
        public int Id { get; private set; }
        public string NewName { get; private set; }

        public UpdateAttributeNameCommand(string newName, int id)
        {
            NewName = newName;
            Id = id;
        }
    }
}
