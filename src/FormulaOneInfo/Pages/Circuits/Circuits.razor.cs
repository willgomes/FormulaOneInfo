namespace FormulaOneInfo.Pages.Circuits
{
    public sealed partial class Circuits
    {
        public bool Loading = true;
        public List<ApplicationCore.Models.Circuit.Circuit> CircuitsInfo = new();

        public Dictionary<string, string> Flags = new()
        {
            { "Germany", "de" },
            { "Australia", "au" },
            { "Bahrain", "bh" },
            { "Vietnam", "vn" },
            { "China", "cn" },
            { "Netherlands", "nl" },
            { "Spain" , "es" },
            { "Monaco", "mc" },
            { "Azerbaijan", "az" },
            { "Canada", "ca" },
            { "France", "fr" },
            { "Austria", "at" },
            { "Great Britain", "gb" },
            { "Hungary", "hu" },
            { "Belgium", "be" },
            { "Italy", "it" },
            { "Singapore", "sg" },
            { "Russia", "ru" },
            { "Japan", "jp" },
            { "USA", "us" },
            { "Mexico", "mx" },
            { "Brazil", "br" },
            { "Abu Dhabi", "ad" },
            { "Portugal", "pt" },
            { "Turkey", "tr" },
            { "Saudi Arabia", "sa" },
            { "Qatar", "qa" }
        };

        protected override async Task OnInitializedAsync()
        {
            await ListCircuitsAsync();
            Loading = false;
        }

        private async Task ListCircuitsAsync()
        {
            var circuitResult = await FormulaOneServiceApi.GetCircuitAsync();
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