using Stadsjutters1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Stadsjutters1;

public partial class SettingsPage : ContentPage
{
    public SettingsPage()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(NotificationSettingsPage), typeof(NotificationSettingsPage));
        Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
        var items = new List<Item>
        {
            new() { Name = "Accountinstelling", Icon = "person_24dp_000000.png" },
            new() { Name = "Notificatie-instellingen", Icon = "notifications_24dp_e8eaed.png" }
        };

        MyListView.ItemsSource = items;
    }

    private async void MyListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item is Item tappedItem)
        {
            if (tappedItem.Name == "Accountinstelling")
            {
                await Shell.Current.GoToAsync(nameof(AccountSettingsPage)); // Navigate to AccountSettingsPage
            }
            else if (tappedItem.Name == "Notificatie-instellingen")
            {
                await Shell.Current.GoToAsync(nameof(NotificationSettingsPage)); // Navigate to NotificationSettingsPage
            }
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
        public string? Name { get; set; }
        public string? Icon { get; set; }
    }
}