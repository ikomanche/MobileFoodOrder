using Firebase.Database;
using Firebase.Database.Query;
using FoodOrder.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FoodOrder.Helpers
{
    public class AddCategoryData
    {
        public List<Category> Categories { get; set; }

        FirebaseClient client;

        public AddCategoryData()
        {
            client = new FirebaseClient("https://foodorderingapp-1ff29-default-rtdb.firebaseio.com/");
            Categories = new List<Category>()
            {
                new Category()
                {
                    CategoryID = 1,
                    CategoryName = "Burger",
                    CategoryPoster = "MainBurger",
                    ImageURL = "Burger.png"
                },
                new Category()
                {
                    CategoryID = 2,
                    CategoryName = "Pizza",
                    CategoryPoster = "MainPizza",
                    ImageURL = "Pizza.png"
                },
                new Category()
                {
                    CategoryID = 3,
                    CategoryName = "Desserts",
                    CategoryPoster = "MainDessert",
                    ImageURL = "Dessert.png"
                },
                new Category()
                {
                    CategoryID = 4,
                    CategoryName = "Veg Burger",
                    CategoryPoster = "MainBurger",
                    ImageURL = "Burger.png"
                },
                new Category()
                {
                    CategoryID = 5,
                    CategoryName = "Veg Pizza",
                    CategoryPoster = "MainPizza",
                    ImageURL = "Pizza.png"
                },
                new Category()
                {
                    CategoryID = 6,
                    CategoryName = "Cake",
                    CategoryPoster = "MainDessert.png",
                    ImageURL = "Dessert.png"
                }
            };            
        }

        public async Task AddCategoriesAsync()
        {
            try
            {
                foreach(var category in Categories)
                {
                    await client.Child("Categories").PostAsync(new Category()
                    {
                        CategoryID = category.CategoryID,
                        CategoryName = category.CategoryName,
                        CategoryPoster = category.CategoryPoster,
                        ImageURL = category.ImageURL
                    });
                }
            }
            catch(Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
