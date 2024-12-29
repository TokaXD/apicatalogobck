using ApiCatalogo.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Context;

public class ApiCatalogoContext : DbContext
{
    public ApiCatalogoContext(DbContextOptions<ApiCatalogoContext> options) : base(options)
    {
    }

    public DbSet<Product>? Products { get; set; }
    public DbSet<Category>? Categories { get; set; }
}