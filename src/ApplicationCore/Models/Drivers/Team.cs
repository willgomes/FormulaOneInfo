
using System.Text.Json.Serialization;

namespace FormulaOneInfo.ApplicationCore.Models.Drivers;

public record Team
{
    [JsonPropertyName("id")]
    public int Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("logo")]
    public string? Logo { get; init; }
}

