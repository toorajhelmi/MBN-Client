using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MessageBankNet.Models;
using MessageBankNet.ViewModels;

namespace MessageBankNet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();
            viewModel = new ItemDetailViewModel();
            BindingContext = viewModel;
        }
    }
}