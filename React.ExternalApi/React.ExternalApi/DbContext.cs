using Microsoft.EntityFrameworkCore;
using React.ExternalApi.Model;

public class SchoolContext : DbContext
{
    public SchoolContext(DbContextOptions<SchoolContext> options)
        : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
}
