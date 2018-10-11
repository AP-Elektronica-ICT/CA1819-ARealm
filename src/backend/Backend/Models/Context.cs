using Microsoft.EntityFrameworkCore;

namespace Models
{
    public class CollectionContext : DbContext
    {
        public CollectionContext(DbContextOptions<CollectionContext> options)
            : base(options)
        {

        }

        //add database tables
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<TodoItem2> TodoItems2 { get; set; }

        public DbSet<Session> Sessions{get;set;}
        public DbSet<District> Districts {get;set;}
        public DbSet<PhotoTask> PhotoTasks {get;set;}
        public DbSet<PuzzleTask> PuzzleTasks {get;set;}
        public DbSet<LocationTask> LocationTasks {get;set;}
        public DbSet<Team> Teams {get;set;}


    }
}
//main class that coordinates Entity Framework functionality for a given data model.