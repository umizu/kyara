namespace Kyara.Contracts.Characters;

public class CharacterResponse
{
    public string Name { get; set; } = default!;
    public string Image { get; set; } = default!;
    public int Rating { get; set; }
}
