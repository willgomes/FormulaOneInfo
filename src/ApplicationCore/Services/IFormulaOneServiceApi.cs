namespace FormulaOneInfo.ApplicationCore.Services;

using FormulaOneInfo.ApplicationCore.Models.Circuit;
using FormulaOneInfo.ApplicationCore.Models.Drivers;

using Refit;

public interface IFormulaOneServiceApi
{
    [Get("/circuits")]
    public Task<CircuitRoot> GetCircuitAsync([AliasAs("id")] string? circuitId = null);

    [Get("/drivers")]
    public Task<DriverRoot> GetDriverAsync([AliasAs("name")] string driverName);
}