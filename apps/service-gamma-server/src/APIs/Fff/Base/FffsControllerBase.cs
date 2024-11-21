using Microsoft.AspNetCore.Mvc;
using ServiceGamma.APIs;

namespace ServiceGamma.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class FffsControllerBase : ControllerBase
{
    protected readonly IFffsService _service;

    public FffsControllerBase(IFffsService service)
    {
        _service = service;
    }
}
