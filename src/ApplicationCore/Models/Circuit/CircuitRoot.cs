using System.Text.Json.Serialization;

namespace FormulaOneInfo.ApplicationCore.Models.Circuit;

public record CircuitRoot
{
    [JsonPropertyName("response")]
    public List<Circuit>? Circuits { get; init; }
}