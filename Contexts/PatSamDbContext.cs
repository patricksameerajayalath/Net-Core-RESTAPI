using Microsoft.EntityFrameworkCore;
using PatSamRESTAPI.Model;

namespace PatSamRESTAPI.Contexts
{
    public class PatSamDbContext: DbContext
    {

        public PatSamDbContext(DbContextOptions<PatSamDbContext> options): base(options)
        {
        }

        // Entities
        public DbSet<Employee> Employee { get; set; }
    }
}
