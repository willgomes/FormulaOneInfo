
using System.Text.Json.Serialization;

namespace FormulaOneInfo.ApplicationCore.Models.Drivers;

public record Constructor
{
    [JsonPropertyName("season")]
    public int Season { get; init; }

    [JsonPropertyName("team")]
    public Team? Team { get; init; }
}

