using System.ComponentModel;
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

    public async Task<IEnumerable<Character>> GetAllAsync()
    {
        return await _dbCtx.Characters
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<bool> CreateAsync(Character character)
    {
        await _dbCtx.Characters.AddAsync(character);
        return await _dbCtx.SaveChangesAsync() > 0;
    }
}
