namespace FormulaOneInfo.ApplicationCore.Models.Circuit;

public record LapRecord
{
    public string? Time { get; init; }
    public string? Driver { get; init; }
    public string? Year { get; init; }
}
