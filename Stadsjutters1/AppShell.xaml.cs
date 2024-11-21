using System.Windows.Input;

namespace Stadsjutters1;

public partial class AppShell : Shell
{
    public ICommand OpenFlyoutCommand { get; }
    
    public AppShell()
    {
        InitializeComponent();
        
        
        // Command to open the Flyout
        OpenFlyoutCommand = new Command(OpenFlyoutMenu);
        BindingContext = this;
    }
    
    
    private void OpenFlyoutMenu()
    {
        Shell.Current.FlyoutIsPresented = true; // Open het Flyout-menu
    }
}