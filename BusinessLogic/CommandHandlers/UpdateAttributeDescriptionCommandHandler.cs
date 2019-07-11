using DAL.CQRS.Commands;
using System;
using System.Linq;

namespace DAL.CQRS.CommandHandlers
{
    public class UpdateAttributeDescriptionCommandHandler : CommandHandlerBase<UpdateAttributeDescriptionCommand>
    {
        public override void Handle(UpdateAttributeDescriptionCommand command)
        {
            if (command == null)
            {
                throw new ArgumentException("command parameter is null");
            }

            var attribute = Context.UnitOfWork.DbContext.Attributes.FirstOrDefault(x => x.Id == command.Id);
            if (attribute == null)
            {
                throw new Exception($"attribute with id:{command.Id} doesn't exists");
            }

            attribute.Description = command.NewDescription;
        }
    }
}
