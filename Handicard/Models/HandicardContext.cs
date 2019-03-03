using Microsoft.EntityFrameworkCore;

namespace Handicard.Models
{
    public class HandicardContext : DbContext
    {
        public HandicardContext(DbContextOptions<HandicardContext> options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
    }
}
