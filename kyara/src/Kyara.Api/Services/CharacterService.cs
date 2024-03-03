using Kyara.Api.Data;
using Kyara.Api.Domain;
using Microsoft.EntityFrameworkCore;

namespace Kyara.Api.Services;

public class CharacterService
{
    private readonly AppDbContext _dbCtx;

    public CharacterService(AppDbContext dbCtx)
    {
        _dbCtx = dbCtx;
    }

    public async Task<(IEnumerable<Character> characters, int totalPages)> GetAllAsync(
        int pageSize, int page)
    {
        var total = await _dbCtx.Characters.CountAsync();

        return (await _dbCtx.Characters
            .AsNoTracking()
            .OrderBy(x => x.Id)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(), total);
    }

    public async Task<bool> CreateAsync(Character character)
    {
        await _dbCtx.Characters.AddAsync(character);
        return await _dbCtx.SaveChangesAsync() > 0;
    }

    public async Task<Character?> GetByIdAsync(Guid id)
    {
        return await _dbCtx.Characters
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        if (await GetByIdAsync(id) is not { } character)
            return false;

        _dbCtx.Characters.Remove(character);
        return await _dbCtx.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateAsync(Guid id, string name, string image, int rating)
    {
        if (await GetByIdAsync(id) is not { } character)
            return false;

        character.Rating = rating;
        character.Name = name;
        character.Image = image;
        
        _dbCtx.Characters.Update(character);
        return await _dbCtx.SaveChangesAsync() > 0;
    }
}
