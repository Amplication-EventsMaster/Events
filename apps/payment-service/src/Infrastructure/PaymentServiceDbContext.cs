using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PaymentService.Infrastructure;

public class PaymentServiceDbContext : IdentityDbContext<IdentityUser>
{
    public PaymentServiceDbContext(DbContextOptions<PaymentServiceDbContext> options)
        : base(options) { }
}
