﻿using System;
using System.Linq;
using DAL.CQRS.Commands;

namespace DAL.CQRS.CommandHandlers
{
    public class UpdateAttributeNameCommandHandler: HandlerBase, ICommandHandler<UpdateAttributeNameCommand>
    {
        public UpdateAttributeNameCommandHandler(AttributeContext context)
            :base(context)
        {
        }

        public void Handle(UpdateAttributeNameCommand command)
        {
            if (command == null)
            {
                throw new ArgumentException("command parameter is null");
            }

            var attribute = Context.Attributes.FirstOrDefault(x => x.Id == command.Id);
            if (attribute == null)
            {
                throw new Exception($"attribute with id:{command.Id} doesn't exists");
            }

            attribute.Name = command.NewName;
            Context.SaveChanges();
        }
    }
}
