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

        //add database tables
        public DbSet<Session> Sessions{get;set;}
        public DbSet<District> Districts {get;set;}
        public DbSet<PhotoTask> PhotoTasks {get;set;}
        public DbSet<PuzzleTask> PuzzleTasks {get;set;}
        public DbSet<LocationTask> LocationTasks {get;set;}
        public DbSet<Team> Teams { get; set; }
        public DbSet<LockedDistricts> LockedDistricts { get; set; }
        public DbSet<SessionCode> SessionCodes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<District>() //configure 1-many relationship 
                .HasOne(d => d.Task) // task-district
                .WithMany(d => d.Districts)
                .HasForeignKey(d => d.TaskId);

            modelBuilder.Entity<SessionCode>() //configure 1-1 relationship
                    .HasOne(d => d.Session) // session -sessioncode
                    .WithOne(d => d.SessionCode)
                    .HasForeignKey<SessionCode>(d => d.SessionId)
                    .IsRequired(false);

            modelBuilder.Entity<District>() // configure 1-many relationship 
                .HasOne(d => d.Session)     // session-districts
                .WithMany(d => d.Districts)
                .HasForeignKey(d => d.SessionId)
                .IsRequired(false);


            modelBuilder.Entity<Team>() // configure 1-many relationship 
                .HasOne(d => d.Session) // session-teams
                .WithMany(d => d.Teams)
                .HasForeignKey(d => d.SessionId);

            

        }

    }
}
//main class that coordinates Entity Framework functionality for a given data model.