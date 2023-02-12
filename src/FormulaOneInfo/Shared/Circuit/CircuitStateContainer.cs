namespace FormulaOneInfo.Shared.Circuit;

public class CircuitStateContainer
{
    public ApplicationCore.Models.Circuit.Circuit Circuit { get; set; }

    public event Action OnStateChange;

    public void SetValue(ApplicationCore.Models.Circuit.Circuit circuit)
    {
        this.Circuit = circuit;
        NotifyStateChanged();
    }
    private void NotifyStateChanged() => OnStateChange?.Invoke();
}