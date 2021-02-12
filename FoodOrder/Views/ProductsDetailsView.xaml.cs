using FoodOrder.Model;
using FoodOrder.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodOrder.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsDetailsView : ContentPage
    {
        ProductDetailsViewModel pvm;
        public ProductsDetailsView(FoodItem foodItem)
        {
            InitializeComponent();
            pvm = new ProductDetailsViewModel(foodItem);
            this.BindingContext = pvm;
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}