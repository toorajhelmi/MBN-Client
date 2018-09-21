using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace MessageBankNet.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://neudesic.com")));
        }

        public ICommand OpenWebCommand { get; }
    }
}