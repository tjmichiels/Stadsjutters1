using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace Stadsjutters1.ViewModel
{
    public partial class MainViewModel: ObservableObject
    { 
        [ObservableProperty]
        public String text;
       
    }
}
