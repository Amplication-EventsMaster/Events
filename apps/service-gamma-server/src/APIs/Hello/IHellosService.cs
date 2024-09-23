using ServiceGamma.APIs.Common;
using ServiceGamma.APIs.Dtos;

namespace ServiceGamma.APIs;

public interface IHellosService
{
    /// <summary>
    /// Create one hello
    /// </summary>
    public Task<Hello> CreateHello(HelloCreateInput hello);

    /// <summary>
    /// Delete one hello
    /// </summary>
    public Task DeleteHello(HelloWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many hellos
    /// </summary>
    public Task<List<Hello>> Hellos(HelloFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about hello records
    /// </summary>
    public Task<MetadataDto> HellosMeta(HelloFindManyArgs findManyArgs);

    /// <summary>
    /// Get one hello
    /// </summary>
    public Task<Hello> Hello(HelloWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one hello
    /// </summary>
    public Task UpdateHello(HelloWhereUniqueInput uniqueId, HelloUpdateInput updateDto);
}
