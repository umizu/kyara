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
        var totalPages = Math.Ceiling(await _dbCtx.Characters.CountAsync() / (double)pageSize);

        return (await _dbCtx.Characters
            .AsNoTracking()
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(), (int)totalPages);
    }

    public async Task<bool> CreateAsync(Character character)
    {
        await _dbCtx.Characters.AddAsync(character);
        return await _dbCtx.SaveChangesAsync() > 0;
    }
}
