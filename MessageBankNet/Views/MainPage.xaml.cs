using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MessageBankNet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public static MainPage Instance;

        public MainPage ()
        {
            InitializeComponent ();

            Instance = this;
        }
    }
}