using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using FoodOrder.Model;
using FoodOrder.Services;

namespace FoodOrder.ViewModels
{
    public class CategoryViewModel : BaseViewModel
    {
        public CategoryViewModel(Category category)
        {
            SelectedCategory = category;
            FoodItemsByCategory = new ObservableCollection<FoodItem>();
            GetFoodItems(category.CategoryID);
        }

        private async void GetFoodItems(int categoryID)
        {
            var data = await new FoodItemService().GetFoodItemsAsync(categoryID);
            FoodItemsByCategory.Clear();

            foreach(var item in data)
            {
                FoodItemsByCategory.Add(item);
            }
            TotalFoodItems = FoodItemsByCategory.Count;
        }

        private Category _SelectedCategory;
        public Category SelectedCategory
        {
            set
            {
                _SelectedCategory = value;
                OnPropertyChanged();
            }
            get
            {
                return _SelectedCategory;
            }
        }

        public ObservableCollection<FoodItem> FoodItemsByCategory { get; set; }

        private int _TotalFoodItems;
        public int TotalFoodItems
        {
            set
            {
                _TotalFoodItems = value;
                OnPropertyChanged();
            }
            get
            {
                return _TotalFoodItems;
            }
        }
    }
}
