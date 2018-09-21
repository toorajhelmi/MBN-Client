using System;
using System.Linq;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using MessageBankNet.Models;
using MessageBankNet.Views;
using Xamarin.Forms;

namespace MessageBankNet.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<Balance> Items { get; set; }

        public Command LoadItemsCommand => new Command(() => ExecuteLoadItemsCommand());

        public ItemsViewModel()
        {
            Title = "Transactions";
            Items = new ObservableCollection<Balance>();

        }
        public async void ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                var balance = await DataStore.GetBalance(Login.AccountNumber);

                if (!TransactionExists(balance))
                {
                    Items.Add(balance);
                }
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private bool TransactionExists(Balance balance)
        {
            return Items.Any(i => i.Ether == balance.Ether &&
                             i.Token == balance.Token &&
                             i.Message == balance.Message);
        }
    }
}