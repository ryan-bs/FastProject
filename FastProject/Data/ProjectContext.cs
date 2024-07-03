using FastProject.Model;
using Microsoft.EntityFrameworkCore;

namespace FastProject.Data;

public class ProjectContext : DbContext
{
    public ProjectContext(DbContextOptions<ProjectContext> opts) : base(opts)
    {
    }

    public DbSet<Project> Projects { get; set; }
}
