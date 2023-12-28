using FirstProject.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<EmployeeModel> Employees { get; set; }
    }
}
