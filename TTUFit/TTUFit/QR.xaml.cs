using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;
using Xamarin.Essentials;


namespace TTUFit
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QR : ContentPage
    {
        public QR()
        {
            InitializeComponent();
        }
        private async void NavigateQR_OnClicked(object sender, EventArgs e)
        {
            var scan = new ZXingScannerPage();
            await Navigation.PushAsync(scan);
            scan.OnScanResult += (result) =>
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();
                    mycode.Text = result.Text;
                    try
                    {
                        await Browser.OpenAsync(result.Text, BrowserLaunchMode.SystemPreferred);
                    }
                    catch (Exception)
                    {

                    }
                });
            };
        }
        private async void NavigateMainMenu_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainMenu());
        }
    }
}