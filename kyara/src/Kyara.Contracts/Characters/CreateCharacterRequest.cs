namespace Kyara.Contracts.Characters;

public record CreateCharacterRequest(
    string Name,
    string Image,
    int Rating);
