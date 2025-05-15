using Microsoft.EntityFrameworkCore;
namespace query1.Models;

public class StudentDbContext : DbContext
{
    public DbSet<Student> _Students { get; set; }

    public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
    {
        
    }
}