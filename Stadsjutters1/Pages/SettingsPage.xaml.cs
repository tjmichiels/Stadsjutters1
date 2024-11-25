using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stadsjutters1;

public partial class SettingsPage : ContentPage
{
    public SettingsPage()
    {
        InitializeComponent();

        var items = new List<Item>
        {
            new() { Name = "Accountinstelling", Icon = "person_24dp_000000.png" },
            new() { Name = "Notificatie-instellingen", Icon = "notifications_24dp_e8eaed.png" }
        };

        MyListView.ItemsSource = items;
    }

    public class Item
    {
        public string? Name { get; set; }
        public string? Icon { get; set; }
    }
}