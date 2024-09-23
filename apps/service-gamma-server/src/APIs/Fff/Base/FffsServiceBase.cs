using ServiceGamma.APIs;
using ServiceGamma.Infrastructure;
using ServiceGamma.Infrastructure.Models;

namespace ServiceGamma.APIs;

public abstract class FffsServiceBase : IFffsService
{
    protected readonly ServiceGammaDbContext _context;

    public FffsServiceBase(ServiceGammaDbContext context)
    {
        _context = context;
    }
}
