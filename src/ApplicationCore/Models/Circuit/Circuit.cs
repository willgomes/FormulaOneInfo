using System.Text.Json.Serialization;

namespace FormulaOneInfo.ApplicationCore.Models.Circuit;

public record Circuit
{
    public int Id { get; init; }
    public string? Name { get; init; }
    public string? Image { get; init; }
    public Competition? Competition { get; init; }

    [JsonPropertyName("first_grand_prix")]
    public int FirstGrandPrix { get; init; }
    public int Laps { get; init; }
    public string? Length { get; init; }

    [JsonPropertyName("race_distance")]
    public string? RaceDistance { get; init; }

    [JsonPropertyName("lap_record")]
    public LapRecord? LapRecord { get; init; }

    public int? Capacity { get; init; }
    public int? Opened { get; init; }
    public string Owner { get; init; } = null!;
}
