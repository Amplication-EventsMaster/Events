using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OrderService_6.Infrastructure;

public class OrderService_6DbContext : IdentityDbContext<IdentityUser>
{
    public OrderService_6DbContext(DbContextOptions<OrderService_6DbContext> options)
        : base(options) { }
}
