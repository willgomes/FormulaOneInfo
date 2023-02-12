namespace FormulaOneInfo.ApplicationCore.Models.Circuit;

public record Competition
{
    public int Id { get; init; }
    public string? Name { get; init; }
    public Location? Location { get; init; }
}
