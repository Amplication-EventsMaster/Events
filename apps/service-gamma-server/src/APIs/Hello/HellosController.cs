using Microsoft.AspNetCore.Mvc;

namespace ServiceGamma.APIs;

[ApiController()]
public class HellosController : HellosControllerBase
{
    public HellosController(IHellosService service)
        : base(service) { }
}
