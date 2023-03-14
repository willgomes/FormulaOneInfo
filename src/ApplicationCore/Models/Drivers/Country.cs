
using System.Text.Json.Serialization;

namespace FormulaOneInfo.ApplicationCore.Models.Drivers;

public record Country
{
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("code")]
    public string? Code { get; init; }
}

