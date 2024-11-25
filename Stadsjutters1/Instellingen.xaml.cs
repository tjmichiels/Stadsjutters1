using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace Stadsjutters1
{
    public partial class Instellingen : ContentPage
    {
        public Instellingen()
        {
            InitializeComponent();

            var items = new List<Item>
                {
                    new() { Name = "Accountinstelling", Icon = "person_24dp_000000.png" },
                    new() { Name = "Notificatie-instellingen", Icon = "notifications_24dp_e8eaed.png" }
                };

            MyListView.ItemsSource = items;
        }
    }

    public class Item
    {
        public string? Name { get; set; }
        public string? Icon { get; set; } 
    }

}
