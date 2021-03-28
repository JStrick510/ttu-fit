using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace TTUFit
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiningOptions : ContentPage
    {
        public DiningOptions()
        {
            InitializeComponent();
            btnOpenMaps.Clicked += BtnOpenMaps_Clicked;
        }

        private void BtnOpenMaps_Clicked(object sender, EventArgs e)
        {
            Location location = new Location();
            Map.OpenAsync(location);
        }

        private async void NavigateMenu_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Menu());
        }

        private async void NavigateMainMenu_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainMenu());
        }
    }
}