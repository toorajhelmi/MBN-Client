using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MessageBankNet.Views;
using MessageBankNet.Services;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace MessageBankNet
{
    public partial class App : Application
    {

        public App ()
        {
            InitializeComponent();

            DependencyService.Register<DataStore>();
            MainPage = new Login();
        }

        protected override void OnStart ()
        {
            // Handle when your app starts
        }

        protected override void OnSleep ()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume ()
        {
            // Handle when your app resumes
        }
    }
}
