using Microsoft.EntityFrameworkCore;

namespace CukorkaApi;

public class SugarDbContext(DbContextOptions<SugarDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
}
