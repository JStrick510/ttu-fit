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
    public partial class ViewMacros : ContentPage
    {
        public ViewMacros()
        {
            InitializeComponent();
        }

        private async void NavigateEditMacros_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditMacros());
        }

        private async void NavigateMainMenu_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainMenu());
        }
    }
}