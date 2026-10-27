using Microsoft.EntityFrameworkCore;
using SupabaseCrudLab.Models;

namespace SupabaseCrudLab.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Product> Products => Set<Product>();
}
