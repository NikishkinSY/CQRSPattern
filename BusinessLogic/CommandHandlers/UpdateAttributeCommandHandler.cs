﻿using BusinessLogic.Commands;
using DAL.CQRS;
using DAL.CQRS.CommandHandlers;
using DAL.CQRS.Commands;

namespace BusinessLogic.CQRS.CommandHandlers
{
    public class UpdateAttributeCommandHandler: CommandHandlerBase<UpdateAttributeCommand>
    {
        public override void Handle(UpdateAttributeCommand command)
        {
            GetHandler<UpdateAttributeNameCommandHandler>().Handle(new UpdateAttributeNameCommand(command.Id, command.NewName));
            GetHandler<UpdateAttributeDescriptionCommandHandler>().Handle(new UpdateAttributeDescriptionCommand(command.Id, command.NewDescription));
        }
    }
}