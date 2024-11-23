using System.Windows.Input;
using Stadsjutters1.Pages;

namespace Stadsjutters1;

public partial class AppShell : Shell
{
    public ICommand OpenFlyoutCommand { get; }
    
    public AppShell()
    {
        InitializeComponent();
        
        
        // Register routes
        Routing.RegisterRoute("//Home", typeof(HomePage));
        
        
        // Command to open the Flyout
        OpenFlyoutCommand = new Command(OpenFlyoutMenu);
        BindingContext = this;
    }
    
    private async void NavigateToHome()
    {
        await Shell.Current.GoToAsync("//Home");
    }
    
    private void OpenFlyoutMenu()
    {
        Shell.Current.FlyoutIsPresented = true; // Open het Flyout-menu
    }
}