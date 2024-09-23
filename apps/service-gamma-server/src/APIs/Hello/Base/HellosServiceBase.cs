using Microsoft.EntityFrameworkCore;
using ServiceGamma.APIs;
using ServiceGamma.APIs.Common;
using ServiceGamma.APIs.Dtos;
using ServiceGamma.APIs.Errors;
using ServiceGamma.APIs.Extensions;
using ServiceGamma.Infrastructure;
using ServiceGamma.Infrastructure.Models;

namespace ServiceGamma.APIs;

public abstract class HellosServiceBase : IHellosService
{
    protected readonly ServiceGammaDbContext _context;

    public HellosServiceBase(ServiceGammaDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one hello
    /// </summary>
    public async Task<Hello> CreateHello(HelloCreateInput createDto)
    {
        var hello = new HelloDbModel
        {
            CreatedAt = createDto.CreatedAt,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            hello.Id = createDto.Id;
        }

        _context.Hellos.Add(hello);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<HelloDbModel>(hello.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one hello
    /// </summary>
    public async Task DeleteHello(HelloWhereUniqueInput uniqueId)
    {
        var hello = await _context.Hellos.FindAsync(uniqueId.Id);
        if (hello == null)
        {
            throw new NotFoundException();
        }

        _context.Hellos.Remove(hello);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many hellos
    /// </summary>
    public async Task<List<Hello>> Hellos(HelloFindManyArgs findManyArgs)
    {
        var hellos = await _context
            .Hellos.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return hellos.ConvertAll(hello => hello.ToDto());
    }

    /// <summary>
    /// Meta data about hello records
    /// </summary>
    public async Task<MetadataDto> HellosMeta(HelloFindManyArgs findManyArgs)
    {
        var count = await _context.Hellos.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one hello
    /// </summary>
    public async Task<Hello> Hello(HelloWhereUniqueInput uniqueId)
    {
        var hellos = await this.Hellos(
            new HelloFindManyArgs { Where = new HelloWhereInput { Id = uniqueId.Id } }
        );
        var hello = hellos.FirstOrDefault();
        if (hello == null)
        {
            throw new NotFoundException();
        }

        return hello;
    }

    /// <summary>
    /// Update one hello
    /// </summary>
    public async Task UpdateHello(HelloWhereUniqueInput uniqueId, HelloUpdateInput updateDto)
    {
        var hello = updateDto.ToModel(uniqueId);

        _context.Entry(hello).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Hellos.Any(e => e.Id == hello.Id))
            {
                throw new NotFoundException();
            }
            else
            {
                throw;
            }
        }
    }
}
