using Kyara.Api.Domain;
using Kyara.Contracts.Characters;
using Kyara.Contracts.Common;

namespace Kyara.Api.Mapping;

public static class DomainToContractMapping
{
    public static Response<CharacterResponse> AsResponse(this IEnumerable<Character> chars)
        => new()
        {
            Items = chars.Select(x => new CharacterResponse
            {
                Name = x.Name,
                Image = x.Image,
                Rating = x.Rating
            })
        };
}
