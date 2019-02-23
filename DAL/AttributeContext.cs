using DAL.DAO;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class AttributeContext: DbContext
    {
        public AttributeContext(DbContextOptions<AttributeContext> options)
            : base(options)
        {
        }
        
        public DbSet<Attribute> Attributes { get; set; }
    }
}
