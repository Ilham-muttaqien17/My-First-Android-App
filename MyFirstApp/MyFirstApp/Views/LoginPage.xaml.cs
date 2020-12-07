using MyFirstApp.Models;
using MyFirstApp.Views.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_Username.TextColor = Constants.MaintextColor;
            Lbl_Password.TextColor = Constants.MaintextColor;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;
            App.StartCheckIfInternet(lbl_NoInternet, this);

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcedure(s, e);
        }

        async void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckInformation())
            {
                await DisplayAlert("Login", "Login Success", "Oke");
                //var result = await App.RestService.Login(user);
                var result = new Token();
                if (result != null)
                {
                    //App.UserDatabase.SaveUser(user);
                    //App.TokenDatabase.SaveToken(result);
                   if(Device.RuntimePlatform == Device.Android)
                    {
                        Application.Current.MainPage = new NavigationPage(new MasterDetail());
                    }
                }
            } else
            {
                await DisplayAlert("Login", "Login Failed, empty username or password", "Oke");
            }
        }
    }
}