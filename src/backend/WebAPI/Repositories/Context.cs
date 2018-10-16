using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories
{
    public class ARealmContext : DbContext
    {
        public ARealmContext(DbContextOptions<ARealmContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<District>()
                .HasOne(district => district.Task)
                .WithOne(task => task.District)
                .HasForeignKey<Task>(task => task.DistrictId); 
        }

        //add database tables
        public DbSet<Session> Sessions{get;set;}
        public DbSet<District> Districts {get;set;}
        public DbSet<PhotoTask> PhotoTasks {get;set;}
        public DbSet<PuzzleTask> PuzzleTasks {get;set;}
        public DbSet<LocationTask> LocationTasks {get;set;}
        public DbSet<Team> Teams {get;set;}


    }
}
//main class that coordinates Entity Framework functionality for a given data model.