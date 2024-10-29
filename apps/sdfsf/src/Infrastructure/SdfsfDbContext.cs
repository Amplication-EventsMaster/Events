using Microsoft.EntityFrameworkCore;

namespace Sdfsf.Infrastructure;

public class SdfsfDbContext : DbContext
{
    public SdfsfDbContext(DbContextOptions<SdfsfDbContext> options)
        : base(options) { }
}
