﻿using System;
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