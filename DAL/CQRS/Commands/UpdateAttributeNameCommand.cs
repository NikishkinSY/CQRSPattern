namespace DAL.CQRS.Commands
{
    public class UpdateAttributeNameCommand: ICommand
    {
        public int Id { get; private set; }
        public string NewName { get; private set; }

        public UpdateAttributeNameCommand(int id, string newName)
        {
            NewName = newName;
            Id = id;
        }
    }
}
