using Microsoft.EntityFrameworkCore;
using Sample.ASPNETCore.Razor.App.Model;

namespace Sample.ASPNETCore.Razor.App.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
}