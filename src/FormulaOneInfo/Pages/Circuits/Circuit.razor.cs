using Microsoft.AspNetCore.Components;

using MudBlazor;

namespace FormulaOneInfo.Pages.Circuits
{
    public sealed partial class Circuit
    {
        [Parameter]
        public string? CircuitId { get; set; }
        private ApplicationCore.Models.Circuit.Circuit? CircuitDetails = new();
        public bool Loading = true;

        private readonly List<BreadcrumbItem> _breadcrumbs = new();

        protected override async Task OnInitializedAsync()
        {
            CircuitDetails = await GetCircuitDetailAsync(CircuitId);

            _breadcrumbs.Add(new BreadcrumbItem("Circuits", href: "Circuits"));
            _breadcrumbs.Add(new BreadcrumbItem(CircuitDetails.Name, href: null, disabled: true));

            Loading = false;
        }

        private async Task<ApplicationCore.Models.Circuit.Circuit?> GetCircuitDetailAsync(string? id)
        {
            if (CircuitState?.Circuit is null)
            {
                var circuitResult = await FormulaOneServiceApi.GetCircuitAsync(id!);

                return circuitResult?.Circuits?.FirstOrDefault();
            }
            else
            {
                return CircuitState.Circuit;
            }
        }

        public void Dispose()
        {
            CircuitState.OnStateChange -= StateHasChanged;
        }
    }
}