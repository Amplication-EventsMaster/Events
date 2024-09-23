using Microsoft.AspNetCore.Mvc;
using ServiceGamma.APIs;

namespace ServiceGamma.APIs;

[ApiController()]
public class FffsController : FffsControllerBase
{
    public FffsController(IFffsService service)
        : base(service) { }
}
