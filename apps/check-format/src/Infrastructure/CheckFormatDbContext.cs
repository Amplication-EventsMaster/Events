using Microsoft.EntityFrameworkCore;

namespace CheckFormat.Infrastructure;

public class CheckFormatDbContext : DbContext
{
    public CheckFormatDbContext(DbContextOptions<CheckFormatDbContext> options)
        : base(options) { }
}
