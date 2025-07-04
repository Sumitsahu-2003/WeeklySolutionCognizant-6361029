// AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using RetailInventory;
public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=RetailDb;Trusted_Connection=True;TrustServerCertificate = true; ");
    }
}
