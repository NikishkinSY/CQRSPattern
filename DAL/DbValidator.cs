using DAL.DAO;
using Microsoft.EntityFrameworkCore.Internal;

namespace DAL
{
    public class DbValidator
    {
        AttributeContext Context { get; }

        public DbValidator(AttributeContext context)
        {
            Context = context;
        }

        public void CheckDb()
        {
            Context.Database.EnsureCreated();
            if (!Context.Attributes.Any())
            {
                Context.Add(new Attribute(1, "Attribute1", "Description1"));
                Context.Add(new Attribute(2, "Attribute2", "Description2"));
                Context.Add(new Attribute(3, "Attribute3", "Description3"));
                Context.SaveChanges();
            }
        }
    }
}
