using MudBlazor;

namespace FormulaOneInfo.Shared
{
    public partial class MainLayout
    {
        bool _drawerOpen = true;
        void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }

        private readonly MudTheme _currentTheme = new()
        {
            Palette = new Palette()
            {
                BackgroundGrey = "#5a5c69",
                TextSecondary = "rgba(255,255,255, 0.50)",
                Primary = "#FF1801",
                AppbarBackground = "#27282f",
            }
        };
    }
}