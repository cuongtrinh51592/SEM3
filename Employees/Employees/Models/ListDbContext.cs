using Microsoft.EntityFrameworkCore;

namespace Employees.Models
{
    public class ListDbContext : DbContext
    {
        public ListDbContext(DbContextOptions<ListDbContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
