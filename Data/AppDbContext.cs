using Microsoft.EntityFrameworkCore;
using ConstructionScheduler.Models;

namespace ConstructionScheduler.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {

        }

        public DbSet<ProjectTask> ProjectTasks { get; set; }
    }
}