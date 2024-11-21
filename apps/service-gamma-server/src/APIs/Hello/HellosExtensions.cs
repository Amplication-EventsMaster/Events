using ServiceGamma.APIs.Dtos;
using ServiceGamma.Infrastructure.Models;

namespace ServiceGamma.APIs.Extensions;

public static class HellosExtensions
{
    public static Hello ToDto(this HelloDbModel model)
    {
        return new Hello
        {
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static HelloDbModel ToModel(
        this HelloUpdateInput updateDto,
        HelloWhereUniqueInput uniqueId
    )
    {
        var hello = new HelloDbModel { Id = uniqueId.Id };

        if (updateDto.CreatedAt != null)
        {
            hello.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            hello.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return hello;
    }
}
