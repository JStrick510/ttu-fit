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

        int count = 0;
        private void Count_OnClicked(object sender, EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You clicked {count} times.";
        }

        private void Update_OnClicked(object sender, EventArgs e)
        {
            age.Text = "Age: " + App.nutri.Age;
            height.Text = "Height: " + App.nutri.Height;
            weight.Text = "Weight: " + App.nutri.CurrentWeight;
        }

        private async void NavigateMainMenu_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainMenu());
        }


    }
}