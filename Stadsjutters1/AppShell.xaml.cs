using Stadsjutters1.Pages;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
namespace Stadsjutters1;

public partial class AppShell : Shell
{

    public ICommand OpenFlyoutCommand { get; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public AppShell()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    {
        InitializeComponent();
        
        // Command to open the Flyout
        BindingContext = this;
        
        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        Routing.RegisterRoute(nameof(FindingsPage), typeof(FindingsPage));
        Routing.RegisterRoute(nameof(PlaceFindingPage), typeof(PlaceFindingPage));
        Routing.RegisterRoute(nameof(ChatsPage), typeof(ChatsPage));
        
        Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
        Routing.RegisterRoute(nameof(MyFindingsPage), typeof(MyFindingsPage));
        Routing.RegisterRoute(nameof(MyReviewsPage), typeof(MyReviewsPage));
        Routing.RegisterRoute(nameof(SavedFindingsPage), typeof(SavedFindingsPage));

        Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
        Routing.RegisterRoute(nameof(NotificationSettingsPage), typeof(NotificationSettingsPage));
        Routing.RegisterRoute(nameof(AccountSettingsPage), typeof(AccountSettingsPage));
        Routing.RegisterRoute(nameof(AdminDashboardPage), typeof(AdminDashboardPage));
        Routing.RegisterRoute(nameof(LogoutPage), typeof(LogoutPage));
        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));




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
    
    [RelayCommand]
    private void OpenFlyoutMenu()
    {
        Shell.Current.FlyoutIsPresented = true; // Open het Flyout-menu
    }


    private async void FlyoutListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item is Item tappedItem)
        {
            // Navigate based on the Name of the tapped item
            switch (tappedItem.Name)
            {
                case "Profiel":
                    await Shell.Current.GoToAsync(nameof(ProfilePage));
                    break;
                case "Mijn vondsten":
                    await Shell.Current.GoToAsync(nameof(MyFindingsPage));
                    break;
                case "Mijn beoordelingen":
                    await Shell.Current.GoToAsync(nameof(MyReviewsPage));
                    break;
                case "Opgeslagen vondsten":
                    await Shell.Current.GoToAsync(nameof(SavedFindingsPage));
                    break;
                case "Instellingen":
                    await Shell.Current.GoToAsync(nameof(SettingsPage));
                    break;
                case "Beheerdersdashboard":
                    await Shell.Current.GoToAsync(nameof(AdminDashboardPage));
                    break;
                case "Log in":
                    await Shell.Current.GoToAsync(nameof(LoginPage));
                    break;
                case "Log uit":
                    await Shell.Current.GoToAsync(nameof(LogoutPage));
                    break;
                default:
                    break;
            }
            Current.FlyoutIsPresented = false;
        }

        // Deselect the item
        ((ListView)sender).SelectedItem = null;
    }

    protected override bool OnBackButtonPressed()
    {
        Shell.Current.GoToAsync("..");
        return true;
    }



    public class Item
    {
        public string Name { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
    }






}



