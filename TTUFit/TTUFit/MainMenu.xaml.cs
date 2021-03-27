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

        int count;
        private void Count_OnClicked(object sender, EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You clicked {count} times.";
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