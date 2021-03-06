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
    public partial class Goals : ContentPage
    {
        public Goals()
        {
            InitializeComponent();
        }


        private void Update_OnClicked(object sender, EventArgs e)
        {
            goalWeight.Text = "Goal Weight: " + App.nutri.GoalWeight;
            currentWeight.Text = "Current Weight: " + App.nutri.CurrentWeight;
            lbsweek.Text = "Weight loss /Week (Lbs): " + App.nutri.PerWeekLbs;
            dailyCals.Text = "Daily Calories: " + App.nutri.DailyCals;
        }

        private async void NavigateMainMenu_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainMenu());
        }


    }
}