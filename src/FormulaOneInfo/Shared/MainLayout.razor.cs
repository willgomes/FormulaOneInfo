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
                Black = "#27282f",
                Background = "#212121",
                BackgroundGrey = "#212121",
                Surface = "#373840",
                TextPrimary = "#E9E9E9",
                TextSecondary = "rgba(255,255,255, 0.50)",
                DrawerBackground = "#212121",
                DrawerText = "#E9E9E9",
                Primary = "#FF1801",
                AppbarBackground = "#27282f"
            }
        };
    }
}