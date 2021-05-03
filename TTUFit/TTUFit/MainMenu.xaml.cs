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
    public partial class MainMenu : ContentPage
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private async void NavigateMealLog_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MealLog());
        }
        private async void NavigateGenerateMealPlan_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GenerateMealPlan());
        }

        private async void NavigateViewMacros_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewMacros());
        }

        private async void NavigateGoals_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Goals());
        }

        private async void NavigateDining_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DiningOptions());
        }

        private async void NavigateProfile_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Profile());
        }

        private async void NavigateQR_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QR());
        }

        private async void NavigateShare_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sharing());
        }

        private void NavigateExit_OnClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        async void OnLogout_Clicked(object sender, EventArgs e)
        {

            App.IsUserLoggedIn = false;
            Navigation.InsertPageBefore(new LoginPage(), this);
            await Navigation.PopAsync();

        }
    }
}