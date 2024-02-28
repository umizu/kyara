namespace Kyara.Api.Domain;
public class Character
{
    public Guid Id { get; init; }
    public string Name { get; set; } = default!;
    public string Image { get; set; } = default!;
    public int Rating { get; set; }
}
