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
    public partial class EditMacros : ContentPage
    {
        public EditMacros()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            fatGoal.Text = "Fat Goal: " + App.nutri.FatGoalPercent;
            carbGoal.Text = "Carb Goal: " + App.nutri.CarbGoalPercent;
            proGoal.Text = "Protien Goal: " + App.nutri.ProGoalPercent;
        }
        private void EditButton_Clicked(object sender, EventArgs e)
        {
            fatGoal.Text = "Fat Goal: " + 15;
            carbGoal.Text = "Carb Goal: " + 40;
            proGoal.Text = "Protien Goal: " + 45;
        }
        private async void NavigateViewMacros_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewMacros());
        }

        private async void NavigateMainMenu_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainMenu());
        }

    }
}