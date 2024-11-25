using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using Stadsjutters1.Pages;

namespace Stadsjutters1;

public partial class AppShell : Shell
{
    public ICommand OpenFlyoutCommand { get; }

    public AppShell()
    {
        InitializeComponent();


        // Register routes
        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));


        // Command to open the Flyout
        OpenFlyoutCommand = new Command(OpenFlyoutMenu);
        BindingContext = this;
    }


    [RelayCommand]
    private void OpenFlyoutMenu()
    {
        Shell.Current.FlyoutIsPresented = true; // Open het Flyout-menu
    }
}