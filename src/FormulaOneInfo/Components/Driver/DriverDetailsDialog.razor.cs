using Microsoft.AspNetCore.Components;

using MudBlazor;

using DriverModel = FormulaOneInfo.ApplicationCore.Models.Drivers;

namespace FormulaOneInfo.Components.Driver;

public partial class DriverDetailsDialog
{
    [CascadingParameter]
    MudDialogInstance MudDialog { get; set; } = null!;

    [Parameter]
    public string DriverName { get; set; } = string.Empty;
    private DriverModel.Driver? _driver;
    private bool _loading = true;

    protected override async Task OnInitializedAsync()
    {
        DriverModel.DriverRoot driverResult = await FormulaOneServiceApi.GetDriverAsync(DriverName);
        _driver = driverResult?.Driver?.FirstOrDefault();

        _loading = false;
    }
}