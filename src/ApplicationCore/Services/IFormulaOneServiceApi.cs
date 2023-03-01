namespace FormulaOneInfo.ApplicationCore.Services;

using FormulaOneInfo.ApplicationCore.Models.Circuit;

using Refit;

public interface IFormulaOneServiceApi
{
    [Get("/circuits")]
    public Task<CircuitRoot> GetCircuitsAsync();

    [Get("/circuits")]
    public Task<CircuitRoot> GetCircuitAsync([AliasAs("id")] string circuitId);
}