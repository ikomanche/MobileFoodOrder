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
    public class AddFoodItemData
    {
        FirebaseClient client;
        public List<FoodItem> FoodItems { get; set; }

        public AddFoodItemData()
        {
            client = new FirebaseClient("https://foodorderingapp-1ff29-default-rtdb.firebaseio.com/");
            FoodItems = new List<FoodItem>()
            {
                new FoodItem
                {
                    ProductID = 1,
                    CategoryID = 1,
                    ImageURl = "MainBurger",
                    Name = "Burger and Pizza Hub 1",
                    Description = "Burger - Pizza - Breakfast",
                    Rating = "4.8",
                    RatingDetail = "(121 ratings)",
                    HomeSelected = "CompleteHearth",
                    Price = 45
                },
                new FoodItem
                {
                    ProductID = 2,
                    CategoryID = 1,
                    ImageURl = "MainBurger",
                    Name = "Burger and Pizza Hub 2",
                    Description = "Burger - Pizza - Breakfast",
                    Rating = "4.8",
                    RatingDetail = "(121 ratings)",
                    HomeSelected = "CompleteHearth",
                    Price = 45
                },
                new FoodItem
                {
                    ProductID = 3,
                    CategoryID = 1,
                    ImageURl = "MainBurger",
                    Name = "Burger and Pizza Hub 3",
                    Description = "Burger - Pizza - Breakfast",
                    Rating = "4.8",
                    RatingDetail = "(121 ratings)",
                    HomeSelected = "CompleteHearth",
                    Price = 45
                },
                new FoodItem
                {
                    ProductID = 4,
                    CategoryID = 1,
                    ImageURl = "MainBurger",
                    Name = "Burger and Pizza Hub 4",
                    Description = "Burger - Pizza - Breakfast",
                    Rating = "4.8",
                    RatingDetail = "(121 ratings)",
                    HomeSelected = "CompleteHearth",
                    Price = 45
                },
                new FoodItem
                {
                    ProductID = 5,
                    CategoryID = 2,
                    ImageURl = "MainPizza",
                    Name = "Pizza",
                    Description = "Pizza - Breakfast",
                    Rating = "4.4",
                    RatingDetail = "(103 ratings)",
                    HomeSelected = "CompleteHearth",
                    Price = 50
                },
                new FoodItem
                {
                    ProductID = 6,
                    CategoryID = 2,
                    ImageURl = "MainPizza",
                    Name = "Pizza",
                    Description = "Pizza - Breakfast",
                    Rating = "4.4",
                    RatingDetail = "(110 ratings)",
                    HomeSelected = "CompleteHearth",
                    Price = 50
                },
                new FoodItem
                {
                    ProductID = 7,
                    CategoryID = 3,
                    ImageURl = "MainDessert",
                    Name = "Cakes",
                    Description = "Cool Cakes - Breakfast",
                    Rating = "4.8",
                    RatingDetail = "(154 ratings)",
                    HomeSelected = "CompleteHearth",
                    Price = 38
                },
                new FoodItem
                {
                    ProductID = 8,
                    CategoryID = 3,
                    ImageURl = "MainDessert",
                    Name = "Cakes",
                    Description = "Cool Cakes - Breakfast",
                    Rating = "4.8",
                    RatingDetail = "(154 ratings)",
                    HomeSelected = "CompleteHearth",
                    Price = 38
                }
            };
        }

        public async Task AddFoodItemAsync()
        {
            try
            {
                foreach(var item in FoodItems)
                {
                    await client.Child("FoodItems").PostAsync(new FoodItem()
                    {
                        CategoryID = item.CategoryID,
                        ProductID = item.ProductID,
                        Description = item.Description,
                        HomeSelected = item.HomeSelected,
                        ImageURl = item.ImageURl,
                        Name = item.Name,
                        Price = item.Price,
                        Rating = item.Rating,
                        RatingDetail = item.RatingDetail
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
