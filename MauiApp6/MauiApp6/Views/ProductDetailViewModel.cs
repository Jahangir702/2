using MauiApp6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp6.Views
{
    // ProductDetailViewModel.cs
    public class ProductDetailViewModel : INotifyPropertyChanged
    {
        private Product _product;

        public ProductDetailViewModel(int productId)
        {
            _product = new ProductRepository().GetProductById(productId);
        }

        public Product Product
        {
            get => _product;
            set
            {
                _product = value;
                OnPropertyChanged(nameof(Product));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
