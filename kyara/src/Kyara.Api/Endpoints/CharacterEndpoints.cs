using Kyara.Api.Services;
using Kyara.Api.Mapping;
using Microsoft.AspNetCore.Mvc;

namespace Kyara.Api.Endpoints;

public static class CharacterEndpoints
{
    public static void UseCharacterEndpoints(this IEndpointRouteBuilder app)
    {
        var charGroup = app.NewVersionedApi("characters")
            .MapGroup("api/v{version:apiVersion}/characters")
            .HasApiVersion(1);

        charGroup.MapGet("/", GetCharacters)
            .MapToApiVersion(1);
    }

    private static async Task<IResult> GetCharacters(
        CharacterService charService,
        int pageSize = 10,
        int page = 1)
    {
        
        var (results, totalPages) = await charService.GetAllAsync(pageSize, page);
        return Results.Ok(results.AsResponse(page, totalPages));

    }
}
