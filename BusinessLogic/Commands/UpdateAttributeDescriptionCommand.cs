namespace DAL.CQRS.Commands
{
    public class UpdateAttributeDescriptionCommand : ICommand
    {
        public int Id { get; private set; }
        public string NewDescription { get; private set; }

        public UpdateAttributeDescriptionCommand(int id, string newDescription)
        {
            NewDescription = newDescription;
            Id = id;
        }
    }
}
