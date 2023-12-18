using MauiApp6.Models;

namespace MauiApp6.Views;

public partial class ProductDetailPage : ContentPage
{
	public ProductDetailPage(int productId)
	{
		InitializeComponent();
        BindingContext = new ProductDetailViewModel(productId);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is ProductDetailViewModel viewModel)
        {
            Cart.Instance.AddToCart(viewModel.Product);
            
            DisplayAlert("Success", "Product added to cart!", "OK");
        }
    }
}