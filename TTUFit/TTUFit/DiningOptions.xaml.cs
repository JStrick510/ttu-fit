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

        public List<DBHandle.Food> all_food_items;
        public List<DBHandle.Dining_Location> meal_data;
        private double value;
        public List<string> dl_names;
        public string[] CommonsNames = { "Commons Greens And Things Salads", "Commons Just Say Cheese Sandwiches And Soups", "Commons Kahns Wok", "Commons Kluckrs Chicken", "Commons Parrilla Mexican" };
        public string[] MarketNames = { "Market Breakfast", "Market Carvery", "Market Chop Stix Grill And Wings", "Market Day Break Cafe", "Market Salads Sandwiches Subs And Spuds", "Market Tech Mex" };
        public string[] SUBNames = { "Paciugo Nutritionals", "Sams Sub Nutritionals", "Smart Chocies Nutritionals", "Zis Nutritionals", "1923 Nutritionals", "Bistro Nutritionals" };
        public string[] SamsWest = { "Green Works", "Sams Place Late Night", "Sams West Breakfast", "Tuscan Kitchen", "West End Grill" };
        public string[] WestVillage = { "Raider Exchange Nutritionals" };
        public string[] UnionPlaza = { "Raider Pit B B Q Nutritionals", "Union Grill Nutrition" };
        public string[] MurrayHall = { "Sams Murray Nutrition" };
        public string[] SneedHall = { "Sneed Nutritionals" };
        public string[] WallGates = { "Wall Gates Asian And Salad", "Wall Gates Breakfast And Smoothie Central", "Wall Gates Pizza And Pasta", "Wall Gates Red Raider Cantina", "Wall Gates The Grill" };
        public string[] GordonBledsoe = { "Fresh Plate Nutritionals For Week Day Menu" };

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
            btnOpenMaps10.Clicked += BtnOpenMaps10_Clicked; //Wall Gates

            this.BindingContext = this;

            dl_names = App.SE.DL_Names();

            meal_data = App.SE.get_TTU_Meal_Data();
            int index = Convert.ToInt32(value);
            all_food_items = meal_data[index].AllFood;




        }

        private bool _isVisible = false;

        public new bool IsVisible
        {
            get
            {
                return _isVisible;
            }
            set
            {
                _isVisible = true;
                RaisePropertyChanged("IsVisible");
            }
        }

        private void RaisePropertyChanged(string v)
        {
            throw new NotImplementedException();
        }

        private void Update_OnClicked(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(value);
            all_food_items = meal_data[index].AllFood;

            foreach (string s in CommonsNames)
            {
                if (s.Contains(dl_names[index]))
                {
                    btnOpenMaps1.IsVisible = true;
                    btnOpenMaps2.IsVisible = false;
                    btnOpenMaps3.IsVisible = false;
                    btnOpenMaps4.IsVisible = false;
                    btnOpenMaps5.IsVisible = false;
                    btnOpenMaps6.IsVisible = false;
                    btnOpenMaps7.IsVisible = false;
                    btnOpenMaps8.IsVisible = false;
                    btnOpenMaps9.IsVisible = false;
                    btnOpenMaps10.IsVisible = false;
                }
            }
            foreach (string s in MarketNames)
            {
                if (s.Contains(dl_names[index]))
                {
                    btnOpenMaps1.IsVisible = false;
                    btnOpenMaps2.IsVisible = true;
                    btnOpenMaps3.IsVisible = false;
                    btnOpenMaps4.IsVisible = false;
                    btnOpenMaps5.IsVisible = false;
                    btnOpenMaps6.IsVisible = false;
                    btnOpenMaps7.IsVisible = false;
                    btnOpenMaps8.IsVisible = false;
                    btnOpenMaps9.IsVisible = false;
                    btnOpenMaps10.IsVisible = false;
                }
            }
            foreach (string s in SUBNames)
            {
                if (s.Contains(dl_names[index]))
                {
                    btnOpenMaps1.IsVisible = false;
                    btnOpenMaps2.IsVisible = false;
                    btnOpenMaps3.IsVisible = true;
                    btnOpenMaps4.IsVisible = false;
                    btnOpenMaps5.IsVisible = false;
                    btnOpenMaps6.IsVisible = false;
                    btnOpenMaps7.IsVisible = false;
                    btnOpenMaps8.IsVisible = false;
                    btnOpenMaps9.IsVisible = false;
                    btnOpenMaps10.IsVisible = false;
                }
            }
            foreach (string s in GordonBledsoe)
            {
                if (s.Contains(dl_names[index]))
                {
                    btnOpenMaps1.IsVisible = false;
                    btnOpenMaps2.IsVisible = false;
                    btnOpenMaps3.IsVisible = false;
                    btnOpenMaps4.IsVisible = true;
                    btnOpenMaps5.IsVisible = false;
                    btnOpenMaps6.IsVisible = false;
                    btnOpenMaps7.IsVisible = false;
                    btnOpenMaps8.IsVisible = false;
                    btnOpenMaps9.IsVisible = false;
                    btnOpenMaps10.IsVisible = false;
                }
            }
            foreach (string s in SamsWest)
            {
                if (s.Contains(dl_names[index]))
                {
                    btnOpenMaps1.IsVisible = false;
                    btnOpenMaps2.IsVisible = false;
                    btnOpenMaps3.IsVisible = false;
                    btnOpenMaps4.IsVisible = false;
                    btnOpenMaps5.IsVisible = true;
                    btnOpenMaps6.IsVisible = false;
                    btnOpenMaps7.IsVisible = false;
                    btnOpenMaps8.IsVisible = false;
                    btnOpenMaps9.IsVisible = false;
                    btnOpenMaps10.IsVisible = false;
                }
            }
            foreach (string s in WestVillage)
            {
                if (s.Contains(dl_names[index]))
                {
                    btnOpenMaps1.IsVisible = false;
                    btnOpenMaps2.IsVisible = false;
                    btnOpenMaps3.IsVisible = false;
                    btnOpenMaps4.IsVisible = false;
                    btnOpenMaps5.IsVisible = false;
                    btnOpenMaps6.IsVisible = true;
                    btnOpenMaps7.IsVisible = false;
                    btnOpenMaps8.IsVisible = false;
                    btnOpenMaps9.IsVisible = false;
                    btnOpenMaps10.IsVisible = false;
                }
            }
            foreach (string s in UnionPlaza)
            {
                if (s.Contains(dl_names[index]))
                {
                    btnOpenMaps1.IsVisible = false;
                    btnOpenMaps2.IsVisible = false;
                    btnOpenMaps3.IsVisible = false;
                    btnOpenMaps4.IsVisible = false;
                    btnOpenMaps5.IsVisible = false;
                    btnOpenMaps6.IsVisible = false;
                    btnOpenMaps7.IsVisible = true;
                    btnOpenMaps8.IsVisible = false;
                    btnOpenMaps9.IsVisible = false;
                    btnOpenMaps10.IsVisible = false;
                }
            }
            foreach (string s in MurrayHall)
            {
                if (s.Contains(dl_names[index]))
                {
                    btnOpenMaps1.IsVisible = false;
                    btnOpenMaps2.IsVisible = false;
                    btnOpenMaps3.IsVisible = false;
                    btnOpenMaps4.IsVisible = false;
                    btnOpenMaps5.IsVisible = false;
                    btnOpenMaps6.IsVisible = false;
                    btnOpenMaps7.IsVisible = false;
                    btnOpenMaps8.IsVisible = true;
                    btnOpenMaps9.IsVisible = false;
                    btnOpenMaps10.IsVisible = false;
                }
            }
            foreach (string s in SneedHall)
            {
                if (s.Contains(dl_names[index]))
                {
                    btnOpenMaps1.IsVisible = false;
                    btnOpenMaps2.IsVisible = false;
                    btnOpenMaps3.IsVisible = false;
                    btnOpenMaps4.IsVisible = false;
                    btnOpenMaps5.IsVisible = false;
                    btnOpenMaps6.IsVisible = false;
                    btnOpenMaps7.IsVisible = false;
                    btnOpenMaps8.IsVisible = false;
                    btnOpenMaps9.IsVisible = true;
                    btnOpenMaps10.IsVisible = false;
                }
            }
            foreach (string s in WallGates)
            {
                if (s.Contains(dl_names[index]))
                {
                    btnOpenMaps1.IsVisible = false;
                    btnOpenMaps2.IsVisible = false;
                    btnOpenMaps3.IsVisible = false;
                    btnOpenMaps4.IsVisible = false;
                    btnOpenMaps5.IsVisible = false;
                    btnOpenMaps6.IsVisible = false;
                    btnOpenMaps7.IsVisible = false;
                    btnOpenMaps8.IsVisible = false;
                    btnOpenMaps9.IsVisible = false;
                    btnOpenMaps10.IsVisible = true;
                }
            }

        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            value = args.NewValue;
            int index = Convert.ToInt32(value);
            string output = "Dining Location: " + dl_names[index];
            displayLabel.Text = output;
        }


        private async void NavigateMenu_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Menu());
        }

        private async void NavigateMainMenu_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainMenu());
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
            Location location = new Location(33.579892, -101.883964);
            var options = new MapLaunchOptions { Name = "Sams West" };
            Map.OpenAsync(location, options);
        }
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
    }
}