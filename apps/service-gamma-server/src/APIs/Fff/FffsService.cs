using Microsoft.AspNetCore.Mvc;
using ServiceGamma.Infrastructure;

namespace ServiceGamma.APIs;

public class FffsService : FffsServiceBase
{
    public FffsService(ServiceGammaDbContext context)
        : base(context) { }
}
