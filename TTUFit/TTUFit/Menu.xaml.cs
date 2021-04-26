using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TTUFit
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public List<DBHandle.Food> all_food_items;
        public List<DBHandle.Dining_Location> meal_data;
        private double value;
        public List<string> dl_names;

        public Menu()
        {
            InitializeComponent();
            this.BindingContext = this;

            dl_names = App.SE.DL_Names();

            meal_data = App.SE.get_TTU_Meal_Data();
            int index = Convert.ToInt32(value);
            all_food_items = meal_data[index].AllFood;

            FoodList.ItemsSource = all_food_items;

        }

        private async void NavigateMainMenu_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainMenu());
        }

        private void Update_OnClicked(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(value);
            all_food_items = meal_data[index].AllFood;

            FoodList.ItemsSource = all_food_items;
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            value = args.NewValue;
            int index = Convert.ToInt32(value);
            string output = "Dining Location: " + dl_names[index];
            displayLabel.Text = output;
        }
    }
}