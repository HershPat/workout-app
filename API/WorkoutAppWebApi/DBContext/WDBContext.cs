using Microsoft.EntityFrameworkCore;
using WorkoutAppWebApi.Models;
namespace WorkoutAppWebApi.DBContext
{
    public class WDBContext : DbContext
    {
        public WDBContext(DbContextOptions<WDBContext> options) : base(options)
        {
        }
        public DbSet<Excercise> Excercises { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<WorkoutExercise> WorkoutExercises { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        
    }
}
