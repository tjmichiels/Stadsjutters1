using System.Windows.Input;
namespace Stadsjutters1.Pages;

public partial class NotificationSettingsPage : ContentPage
{
    public ICommand NavigateBackCommand { get; }

    public NotificationSettingsPage()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
        Routing.RegisterRoute(nameof(NotificationSettingsPage), typeof(NotificationSettingsPage));
        NavigateBackCommand = new Command(async () => await Shell.Current.GoToAsync("//HomePage"));
        BindingContext = this;
    }

    protected override bool OnBackButtonPressed()
    {
        Shell.Current.GoToAsync(".."); // Navigate to the previous page
        return true;
    }
}
