using Microsoft.EntityFrameworkCore;
using BugTrackerMvc.Models;


namespace BugTrackerMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> Options) : base(Options){}

        public DbSet<Bug> Bugs { get; set; }
    }
}
