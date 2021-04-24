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
    public partial class SignUp : ContentPage
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private async void LoginButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        async void SignUpButtonClicked(object sender, EventArgs e)
        {
            App.user.Username = usernameEntry.Text;
            App.user.Password = passwordEntry.Text;

            var signUpSucceeded = AreDetailsValid(App.user);
            if (signUpSucceeded)
            {
                var rootpage = Navigation.NavigationStack.FirstOrDefault();
                if (rootpage != null)
                {
                    App.IsUserLoggedIn = true;
                    Navigation.InsertPageBefore(new Profile(), Navigation.NavigationStack.First());
                    await Navigation.PopToRootAsync();
                }
                else
                {
                    ((Button)sender).Text = $"Username or Password invalid";
                }
            }

        }

        bool AreDetailsValid(User user)
        {
            return (!string.IsNullOrWhiteSpace(user.Username) && !string.IsNullOrWhiteSpace(user.Password) && user.Username.Contains("@ttu.edu") && user.Password.Length > 7 && user.Password.Length < 17);
        }
    }
}