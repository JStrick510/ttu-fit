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
    public partial class GenerateMealPlan : ContentPage
    {
        public GenerateMealPlan()
        {
            InitializeComponent();
        }

        private void GenerateMealPlan_Click(object sender, EventArgs args)
        {
            /*
            var algo = new algoclass
            TCal = int(nutri.DailyCals),
            TPro = int(nutri.DailyCals * nutri.Pr0GoalPercent),
            TCar = int(nutri.DailyCals * nutri.CarbGoalPercent),
            TFat = int(nutri.DailyCals * nutri.FatGoalPercent),
            */
        }
        private async void NavigateMainMenu_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainMenu());
        }
    }
}