using FoodOrder.Model;
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
        public ProductsDetailsView(FoodItem foodItem)
        {
            InitializeComponent();
        }
    }
}