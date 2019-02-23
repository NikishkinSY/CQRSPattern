using DAL.DAO;
using Microsoft.EntityFrameworkCore.Internal;

namespace DAL
{
    public static class DbValidator
    {
        public static void CheckDb(AttributeContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Attributes.Any())
            {
                context.Add(new Attribute(1, "Attribute1"));
                context.Add(new Attribute(2, "Attribute2"));
                context.Add(new Attribute(3, "Attribute3"));
                context.SaveChanges();
            }
        }
    }
}
