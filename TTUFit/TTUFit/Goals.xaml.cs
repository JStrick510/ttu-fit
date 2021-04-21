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
            age.Text = "Age: " + App.goals.age;
            height.Text = "Height: " + App.goals.height;
            weight.Text = "Weight: " + App.goals.currentWeight;
            goalweight.Text = "Goal Weight: " + App.goals.goalWeight;
            activity.Text = "Activity Level: " + App.goals.activity;
            App.goals.CalculateDialyCals(App.goals.CalculateMaintenenceCal(App.goals.CalculateBMR()), 1); // Calcluates the user's daily calories with 1 being the goal loss or gain /week
            dayCals.Text = "Daily Calories: " + App.goals.dailyCals;
        }

        private async void NavigateMainMenu_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainMenu());
        }


    }
}