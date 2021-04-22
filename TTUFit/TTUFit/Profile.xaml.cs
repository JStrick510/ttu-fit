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
    public partial class Profile : ContentPage
    {
        public Profile()
        {
            InitializeComponent();
        }

        async void Update_OnClicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(ageEntry.Text) && !string.IsNullOrWhiteSpace(genderEntry.Text) && !string.IsNullOrWhiteSpace(goalWeightEntry.Text) && 
                !string.IsNullOrWhiteSpace(currentWeightEntry.Text) && !string.IsNullOrWhiteSpace(activityEntry.Text))
            {
                App.user.age = int.Parse(ageEntry.Text);

                if (genderEntry.Text.Equals("M"))
                    App.user.gender = (User.Gender)0;
                else
                    App.user.gender = (User.Gender)1;

                App.user.goalWeight = int.Parse(goalWeightEntry.Text);
                App.user.currentWeight = int.Parse(currentWeightEntry.Text);
                App.user.heightInches = int.Parse(heightEntry.Text);

                App.user.activity = (User.Activity)int.Parse(activityEntry.Text);

                Navigation.InsertPageBefore(new MainMenu(), Navigation.NavigationStack.First());
                await Navigation.PopToRootAsync();
            }
            
            else
            {
                ((Button)sender).Text = $"One field left empty, fill all spaces";
            }

        }

    }
}