using Kyara.Api.Services;
using Kyara.Api.Mapping;
using Kyara.Contracts.Characters;
using Kyara.Api.Domain;

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

        charGroup.MapGet("/{id:guid}", GetById)
            .MapToApiVersion(1);

        charGroup.MapDelete("/{id:guid}", DeleteById)
            .MapToApiVersion(1);

        charGroup.MapPost("/", CreateCharacter)
            .MapToApiVersion(1);

        charGroup.MapPut("/{id:guid}", UpdateById)
            .MapToApiVersion(1);
    }

    private static async Task<IResult> UpdateById(
        Guid id,
        UpdateCharacterRequest req,
        CharacterService charService)
    {
        var updated = await charService.UpdateAsync(id, req.Name, req.Image, req.Rating);
        
        if (!updated)
            return Results.NotFound();
        return Results.NoContent();
    }

    private static async Task<IResult> DeleteById(
        Guid id,
        CharacterService charService)
    {
        var deleted = await charService.DeleteAsync(id);
        if (!deleted)
            return Results.NotFound();
        return Results.NoContent();
    }

    private static async Task<IResult> GetCharacters(
        CharacterService charService,
        int perPage = 10,
        int page = 1)
    {

        var (results, total) = await charService.GetAllAsync(perPage, page);
        return Results.Ok(results.AsResponse(page, perPage, total));
    }

    private static async Task<IResult> GetById(
        Guid id,
        CharacterService charService)
    {
        var character = await charService.GetByIdAsync(id);
        if (character is null)
            return Results.NotFound();

        return Results.Ok(character);
    }

    private static async Task<IResult> CreateCharacter(
        CreateCharacterRequest req,
        CharacterService charService)
    {
        var kyara = new Character
        {
            Id = Guid.NewGuid(),
            Name = req.Name,
            Image = req.Image,
            Rating = req.Rating
        };

        var created = await charService.CreateAsync(kyara);
        if (!created)
            return Results.BadRequest("Failed to create character");

        return Results.Created($"/api/v1/characters/{kyara.Id}", kyara);
    }
}
