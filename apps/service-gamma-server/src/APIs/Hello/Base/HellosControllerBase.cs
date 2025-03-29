using Microsoft.AspNetCore.Mvc;
using ServiceGamma.APIs;
using ServiceGamma.APIs.Common;
using ServiceGamma.APIs.Dtos;
using ServiceGamma.APIs.Errors;

namespace ServiceGamma.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class HellosControllerBase : ControllerBase
{
    protected readonly IHellosService _service;

    public HellosControllerBase(IHellosService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one hello
    /// </summary>
    [HttpPost()]
    public async Task<ActionResult<Hello>> CreateHello(HelloCreateInput input)
    {
        var hello = await _service.CreateHello(input);

        return CreatedAtAction(nameof(Hello), new { id = hello.Id }, hello);
    }

    /// <summary>
    /// Delete one hello
    /// </summary>
    [HttpDelete("{Id}")]
    public async Task<ActionResult> DeleteHello([FromRoute()] HelloWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteHello(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many hellos
    /// </summary>
    [HttpGet()]
    public async Task<ActionResult<List<Hello>>> Hellos([FromQuery()] HelloFindManyArgs filter)
    {
        return Ok(await _service.Hellos(filter));
    }

    /// <summary>
    /// Meta data about hello records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> HellosMeta([FromQuery()] HelloFindManyArgs filter)
    {
        return Ok(await _service.HellosMeta(filter));
    }

    /// <summary>
    /// Get one hello
    /// </summary>
    [HttpGet("{Id}")]
    public async Task<ActionResult<Hello>> Hello([FromRoute()] HelloWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Hello(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one hello
    /// </summary>
    [HttpPatch("{Id}")]
    public async Task<ActionResult> UpdateHello(
        [FromRoute()] HelloWhereUniqueInput uniqueId,
        [FromQuery()] HelloUpdateInput helloUpdateDto
    )
    {
        try
        {
            await _service.UpdateHello(uniqueId, helloUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
