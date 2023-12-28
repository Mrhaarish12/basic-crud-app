using Microsoft.EntityFrameworkCore;

namespace FirstProject.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<> MyProperty { get; set; }
    }
}
