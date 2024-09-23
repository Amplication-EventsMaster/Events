using ServiceGamma.Infrastructure;

namespace ServiceGamma.APIs;

public class HellosService : HellosServiceBase
{
    public HellosService(ServiceGammaDbContext context)
        : base(context) { }
}
