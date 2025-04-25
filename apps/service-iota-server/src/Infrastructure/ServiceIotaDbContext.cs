using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ServiceIota.Infrastructure;

public class ServiceIotaDbContext : IdentityDbContext<IdentityUser>
{
    public ServiceIotaDbContext(DbContextOptions<ServiceIotaDbContext> options)
        : base(options) { }
}
