using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MessageBankNet.Views
{
    public partial class Login : ContentPage
    {
        public static string AccountNumber;

        public Login()
        {
            InitializeComponent();
        }

        private async void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Account.Text))
            {
                AccountNumber = Account.Text;
                await Navigation.PushModalAsync(new NavigationPage(new MainPage()));
            }
        }
    }
}
