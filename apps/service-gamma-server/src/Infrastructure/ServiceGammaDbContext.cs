using Microsoft.EntityFrameworkCore;
using ServiceGamma.Infrastructure.Models;

namespace ServiceGamma.Infrastructure;

public class ServiceGammaDbContext : DbContext
{
    public ServiceGammaDbContext(DbContextOptions<ServiceGammaDbContext> options)
        : base(options) { }

    public DbSet<HelloDbModel> Hellos { get; set; }
}
