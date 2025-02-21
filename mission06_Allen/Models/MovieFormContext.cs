using Microsoft.EntityFrameworkCore;

namespace mission06_Allen.Models
{
    public class MovieFormContext : DbContext
    {

        public MovieFormContext(DbContextOptions<MovieFormContext> options): base(options)
        {
        }
        public DbSet<MovieForm> Movies { get; set; } //what builts the table
        public DbSet<Category> Categories { get; set; }
    }
}
