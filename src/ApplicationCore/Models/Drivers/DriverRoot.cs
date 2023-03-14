
using System.Text.Json.Serialization;

namespace FormulaOneInfo.ApplicationCore.Models.Drivers;

public record DriverRoot
{
    [JsonPropertyName("response")]
    public List<Driver>? Driver { get; init; }
}