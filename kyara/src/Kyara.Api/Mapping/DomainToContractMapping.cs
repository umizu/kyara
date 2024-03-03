using Kyara.Api.Domain;
using Kyara.Contracts.Characters;
using Kyara.Contracts.Common;

namespace Kyara.Api.Mapping;

public static class DomainToContractMapping
{
    public static Response<CharacterResponse> AsResponse(this IEnumerable<Character> chars, int page, int perPage, int total)
        => new()
        {
            Page = page,
            TotalItems = total,
            TotalPages = (int)Math.Ceiling(total / (double)perPage),
            Items = chars.Select(x => new CharacterResponse
            {
                Id = x.Id,
                Name = x.Name,
                Image = x.Image,
                Rating = x.Rating
            })
        };
}
