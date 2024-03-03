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
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(), total);
    }

    public async Task<bool> CreateAsync(Character character)
    {
        await _dbCtx.Characters.AddAsync(character);
        return await _dbCtx.SaveChangesAsync() > 0;
    }
}
