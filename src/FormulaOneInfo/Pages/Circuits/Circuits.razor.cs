namespace FormulaOneInfo.Pages.Circuits
{
    public sealed partial class Circuits
    {
        public bool Loading = true;
        public List<ApplicationCore.Models.Circuit.Circuit> CircuitsInfo = new();

        protected override async Task OnInitializedAsync()
        {
            await ListCircuitsAsync();
            Loading = false;
        }

        private async Task ListCircuitsAsync()
        {
            var circuitResult = await FormulaOneServiceApi.GetCircuitsAsync();
            CircuitsInfo.AddRange(circuitResult.Circuits);
        }

        private void ShowCircuitInformation(ApplicationCore.Models.Circuit.Circuit circuit)
        {
            CircuitState.SetValue(circuit);
            UriHelper.NavigateTo($"/CircuitDetails/{circuit.Id}");
        }

        public void Dispose()
        {
            CircuitState.OnStateChange -= StateHasChanged;
        }
    }
}