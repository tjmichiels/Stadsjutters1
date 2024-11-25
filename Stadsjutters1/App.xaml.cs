using Stadsjutters1.Pages;

namespace Stadsjutters1;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
        // MainPage = new HomePage();
    }
}