namespace Kyara.Contracts.Common;

public record Response<T>
{
    public IEnumerable<T> Items { get; set; } = [];
}
