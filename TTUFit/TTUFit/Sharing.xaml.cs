using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.ComponentModel;
using System.IO;



namespace TTUFit
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sharing : ContentPage
    {
        public Sharing()
        {
            InitializeComponent();
        }

        //People can write about their meal plan with explanation and share it by this button. 
        private async void NavigateShare_OnClicked(object sender, EventArgs e)
        {
            try
            {
                await Share.RequestAsync(new ShareTextRequest
                {

                    Text = EntryShare.Text,
                    Title = "Share!"
                });
            }
            catch (Exception)
            {
            }
        }
        //People can make their meal plan as a text file and share it by this button.
        private async void NavigateShareFile_OnClicked(object sender, EventArgs e)
        {
            var info = EntryShare.Text;
            if (string.IsNullOrEmpty(info))
                return;

            var path = string.Empty;
            path = Path.Combine(FileSystem.CacheDirectory, "Meal Plan.txt");

            try
            {
                await Share.RequestAsync(new ShareFileRequest
                {
                    Title = "Hello from Xamarin.Essentials",
                    File = new ShareFile(path)
                });
            }
            catch (Exception)
            {
            }
        }

        private async void NavigateMainMenu_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainMenu());
        }

    }
}