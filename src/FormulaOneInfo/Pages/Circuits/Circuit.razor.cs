using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FormulaOneInfo.Pages.Circuits
{
    public partial class Circuit
    {
        private ApplicationCore.Models.Circuit.Circuit CircuitDetails { get; set; }

        private readonly List<BreadcrumbItem> _breadcrumbs = new();

        protected override void OnInitialized()
        {
            base.OnInitialized();
            CircuitDetails = CircuitState.Circuit;
            _breadcrumbs.Add(new BreadcrumbItem("Circuits", href: "Circuits"));
            _breadcrumbs.Add(new BreadcrumbItem(CircuitDetails.Name, href: null, disabled: true));
        }
    }
}