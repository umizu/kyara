namespace Kyara.Contracts.Common;

public record Response<T>
{
    public int Page { get; set; }
    public int TotalPages { get; set; }
    public IEnumerable<T> Items { get; set; } = [];
}
