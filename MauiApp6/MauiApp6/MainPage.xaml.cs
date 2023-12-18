using MauiApp6.Models;
using MauiApp6.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiApp6
{
    public partial class MainPage : ContentPage
    {
        private List<Product> _products;
        public MainPage()
        {
            InitializeComponent();
            _products = new ProductRepository().GetProducts();
            BindingContext = this;
        }

        public List<Product> Products => _products;

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var selectedProduct = (Product)e.SelectedItem;
            Navigation.PushAsync(new ProductDetailPage(selectedProduct.Id));
            ((ListView)sender).SelectedItem = null;
        }

        private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var product=new ObservableCollection<Product>( ProductRepository.SearchProduct(((SearchBar)sender).Text));
            productListView.ItemsSource = product;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }
    }

}
