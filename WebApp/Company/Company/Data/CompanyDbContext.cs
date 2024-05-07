using Company.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Company.Data
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
