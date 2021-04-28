using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TTUFit
{
    public partial class App : Application
    {
        public static Boolean debug = true;
        public static Boolean IsUserLoggedIn = false;

        public static Goal goals = new Goal(20, 250, 200, 60, 3000, Goal.Activity.Sedentary, Goal.Gender.Male);

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
