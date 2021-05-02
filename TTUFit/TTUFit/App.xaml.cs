using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TTUFit
{
    public partial class App : Application
    {
        public static Boolean debug = true;
        public static Boolean IsUserLoggedIn = false;

        public static Nutrition nutri = new Nutrition(20, 220, 200, 70, 1.5, Goal.Activity.ModerateleyActive, Goal.Gender.Male); //test data

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
