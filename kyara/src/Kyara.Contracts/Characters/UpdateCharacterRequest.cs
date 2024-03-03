namespace Kyara.Contracts.Characters;

public record UpdateCharacterRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public int Rating { get; set; }
}
