using Stadsjutters1.Pages;
using System.Windows.Input;
namespace Stadsjutters1;

public partial class AppShell : Shell
{

    public ICommand OpenFlyoutCommand { get; }

    public AppShell()
    {
        InitializeComponent();



        // Define the flyout items
        var flyoutItems = new List<Item>
        {
            new() { Name = "Profiel", Icon = "person_24dp_f19e39.png" },
            new() { Name = "Mijn vondsten", Icon = "package_2_24dp_000000.png" },
            new() { Name = "Mijn beoordelingen", Icon = "star_24dp_000000.png" },
            new() { Name = "Opgeslagen vondsten", Icon = "bookmark_24dp_000000.png" },
            new() { Name = "Instellingen", Icon = "settings_24dp_000000.png" },
            new() { Name = "Beheerdersdashboard", Icon = "dashboard_2_24dp_000000.png" },
            new() { Name = "Log in", Icon = "login_24dp_000000.png" },
            new() { Name = "Log uit", Icon = "logout_24dp_000000.png" }
        };

        // Set the ListView's item source
        FlyoutListView.ItemsSource = flyoutItems;
    }

    private async void FlyoutListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item is Item tappedItem)
        {
            // Navigate based on the Name of the tapped item
            switch (tappedItem.Name)
            {
                case "Profiel":
                    await Navigation.PushAsync(new ProfilePage());
                    break;
                case "Mijn vondsten":
                    await Navigation.PushAsync(new MyFindingsPage());
                    break;
                case "Mijn beoordelingen":
                    await Navigation.PushAsync(new MyReviewsPage());
                    break;
                case "Opgeslagen vondsten":
                    await Navigation.PushAsync(new SavedFindingsPage());
                    break;
                case "Instellingen":
                    await Navigation.PushAsync(new SettingsPage());
                    break;
                case "Beheerdersdashboard":
                    await Navigation.PushAsync(new AdminDashboardPage());
                    break;
                case "Log in":
                    await Navigation.PushAsync(new LoginPage());
                    break;
                case "Log uit":
                    await Navigation.PushAsync(new LogoutPage());
                    break;
                default:
                    break;
            }
            Current.FlyoutIsPresented = false;
        }

        // Deselect the item
        ((ListView)sender).SelectedItem = null;
    }

    public class Item
    {
        public string Name { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
    }
}



