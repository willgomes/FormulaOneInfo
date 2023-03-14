
using System.Text.Json.Serialization;

namespace FormulaOneInfo.ApplicationCore.Models.Drivers;

public record HighestRaceFinish
{
    [JsonPropertyName("position")]
    public int? Position { get; init; }

    [JsonPropertyName("number")]
    public int? Number { get; init; }
}