using Microsoft.EntityFrameworkCore;

namespace ServiceGamma.Infrastructure;

public class ServiceGammaDbContext : DbContext
{
    public ServiceGammaDbContext(DbContextOptions<ServiceGammaDbContext> options)
        : base(options) { }
}
