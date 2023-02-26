using Microsoft.EntityFrameworkCore;

namespace GalaxyConsole.Database;


public class GalaxyConsoleContext : DbContext
{
    public GalaxyConsoleContext(DbContextOptions<GalaxyConsoleContext> options) : base(options)
    {

    }

    public GalaxyConsoleContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost;Database=School;User Id=sa;Password=Phuoctran@@##412;TrustServerCertificate=true");
    }
    public DbSet<Student> Students { get; set; }
}