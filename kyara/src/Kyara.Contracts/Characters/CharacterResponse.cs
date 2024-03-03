namespace Kyara.Contracts.Characters;

public record CharacterResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string Image { get; set; } = default!;
    public int Rating { get; set; }
}
