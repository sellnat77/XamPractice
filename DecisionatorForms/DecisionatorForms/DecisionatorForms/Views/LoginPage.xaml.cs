using DecisionatorForms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DecisionatorForms.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            App.PostSuccessFacebookAction = async token =>
            {
                //you can use this token to authenticate to the server here
                //call your FacebookLoginService.LoginToServer(token)
                //I'll just navigate to a screen that displays the token:
                await Navigation.PushAsync(new DisplayTokenPage(token));

            };
        }
    }
}
