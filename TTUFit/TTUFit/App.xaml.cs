using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TTUFit
{
    public partial class App : Application
    {
        DBHandle.Set_Up SE = new DBHandle.Set_Up();
        
        public static Boolean IsUserLoggedIn = false;
        public App()
        {
            InitializeComponent();
            SE.ReadTxtFile();
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
