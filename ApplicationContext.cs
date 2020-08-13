using BissnesHour.Models;
using Microsoft.EntityFrameworkCore;

namespace BissnesHour
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {}
        
        public DbSet<ActivityType> ActivityType { get; set; }
        public DbSet<DayWork> DayWork { get; set; }
        public DbSet<DoneOnProject> DoneOnProject { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Role> Role { get; set; }
    }
}