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

        charGroup.MapGet("/", async ([FromServices] CharacterService charService) =>
        {
            var results = await charService.GetAllAsync();
            return Results.Ok(results.AsResponse());
        }).MapToApiVersion(1);
    }
}
