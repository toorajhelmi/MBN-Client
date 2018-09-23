using System;

using MessageBankNet.Models;
using MessageBankNet.Views;
using Xamarin.Forms;

namespace MessageBankNet.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public string To { get; set; }
        public int TokenCount { get; set; }
        public string Message { get; set; }

        public Command SendTokenCommand => new Command(() => SendTransaction());

        private async void SendTransaction()
        {
            if (To == Login.AccountNumber)
            {
                await DataStore.Mint(Login.AccountNumber, TokenCount);
            }
            else
            {
                await DataStore.SendToken(new Transaction
                {
                    Address = To,
                    Tokens = TokenCount,
                    Message = Message
                });
            }

            await MainPage.Instance.DisplayAlert("Success", $"{TokenCount} tokens successfully sent to {To}.", "OK");
            await MainPage.Instance.Navigation.PopAsync();
        }
    }
}
