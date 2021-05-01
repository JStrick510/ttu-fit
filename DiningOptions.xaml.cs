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
            btnOpenMaps1.Clicked += BtnOpenMaps1_Clicked; // The Commons
            btnOpenMaps2.Clicked += BtnOpenMaps2_Clicked; // The Market at Stangle
            btnOpenMaps3.Clicked += BtnOpenMaps3_Clicked; // Student Union Building
            btnOpenMaps4.Clicked += BtnOpenMaps4_Clicked; // Fresh Plate Gordon bledsoe
            btnOpenMaps5.Clicked += BtnOpenMaps5_Clicked; // Sams West
            btnOpenMaps6.Clicked += BtnOpenMaps6_Clicked; // West Village
            btnOpenMaps7.Clicked += BtnOpenMaps7_Clicked; // Union Plaza
            btnOpenMaps8.Clicked += BtnOpenMaps8_Clicked; //Murray Hall
            btnOpenMaps9.Clicked += BtnOpenMaps9_Clicked; //Sneed Hall
            btnOpenMaps10.Clicked += BtnOpenMaps9_Clicked; //Wall Gates

        }

        // The Commons( Greens and things salads, just say cheese sandwhiches and soups, kahns wok, kluckrs chicken, parrilla mexican)
        private void BtnOpenMaps1_Clicked(object sender, EventArgs e)
        {
            Location location = new Location(33.579552, -101.874171);
            var options = new MapLaunchOptions { Name = "The Commons" };
            Map.OpenAsync(location, options);
        }

        //The market (Breakfast, Carvery, Chop Stix Grill and Wings, Day Break Cafe, Salads Sandwiches Subs And Spuds, Tex Mex)
        private void BtnOpenMaps2_Clicked(object sender, EventArgs e)
        {
            Location location = new Location(33.583667, -101.880475);
            var options = new MapLaunchOptions { Name = "The Market" };
            Map.OpenAsync(location, options);
        }

        // SUB (Paciugo, Sams Sub, Smart Choice, Zis nutritionals, 1923, bistro)
        private void BtnOpenMaps3_Clicked(object sender, EventArgs e)
        {
            Location location = new Location(33.581677, -101.875155);
            var options = new MapLaunchOptions { Name = "Student Union Building" };
            Map.OpenAsync(location, options);
        }
        private void BtnOpenMaps4_Clicked(object sender, EventArgs e) 
        {
            Location location = new Location(33.579892, -101.883964);
            var options = new MapLaunchOptions { Name = "Fresh Plate at Bledsoe/Gordon" };
            Map.OpenAsync(location, options);
        }
        //Sams west (Green Works, Sams Late night, breakfast, sams west, tuscan kitchen,west end grill) 
        private void BtnOpenMaps5_Clicked(object sender, EventArgs e)
        {
            Location location = new Location(33.579892, -101.883964);
            var options = new MapLaunchOptions { Name = "Sams West" };
            Map.OpenAsync(location, options);
        }

        // west village (Raider Exchange)
        private void BtnOpenMaps6_Clicked(object sender, EventArgs e) 
        {
            Location location = new Location(33.578742, -101.889472);
            var options = new MapLaunchOptions { Name = "West Village" };
            Map.OpenAsync(location, options);
        }

        // union plaza (Raider Pit BBQ, Union grill)
        private void BtnOpenMaps7_Clicked(object sender, EventArgs e)
        {
            Location location = new Location(33.581725, -101.874338);
            var options = new MapLaunchOptions { Name = "Union Plaza" };
            Map.OpenAsync(location, options);
        }

        //Murray hall (sams)
        private void BtnOpenMaps8_Clicked(object sender, EventArgs e)
        {
            Location location = new Location(33.586492, -101.878691);
            var options = new MapLaunchOptions { Name = "Sam's at Murray Hall" };
            Map.OpenAsync(location, options);
        }

        //Sneed Hall (Sneed nutritionals)
        private void BtnOpenMaps9_Clicked(object sender, EventArgs e)
        {
            Location location = new Location(33.585239, -101.871453);
            var options = new MapLaunchOptions { Name = "Sneed Hall" };
            Map.OpenAsync(location, options);
        }

        //Wall gates (Asian and Salad, breakfast and smoothie central, pizza and pasta, red raider Cantina, the grill)
        private void BtnOpenMaps10_Clicked(object sender, EventArgs e)
        {
            Location location = new Location(33.579199, -101.877013);
            var options = new MapLaunchOptions { Name = "Wall/ Gates" };
            Map.OpenAsync(location, options);
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