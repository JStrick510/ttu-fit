using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TTUFit
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void LogIn_OnClicked(object sender, EventArgs e)
        {
            if(App.IsUserLoggedIn)
            {
                await Navigation.PushAsync(new MainMenu());
            }
            else
            {
                await Navigation.PushAsync(new LoginPage());
            }
        }

        private async void SignUp_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUp());
        }

        private void NavigateExit_OnClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
