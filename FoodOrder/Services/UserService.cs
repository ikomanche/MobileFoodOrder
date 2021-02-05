using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FoodOrder.Model;
using System.Linq;
using Firebase.Database;
using Firebase.Database.Query;

namespace FoodOrder.Services
{
    public class UserService
    {
        FirebaseClient client;

        public UserService()
        {
            client = new FirebaseClient("https://foodorderingapp-1ff29-default-rtdb.firebaseio.com/");
        }

        public async Task<bool> IsUserExist(string uname)
        {
            var user = (await client.Child("Users").OnceAsync<User>())
                .Where(u => u.Object.Username == uname).FirstOrDefault();

            return (user != null);
        }

        public async Task<bool> RegisterUser(string uname,string passwd)
        {
            if(await IsUserExist(uname) == false)
            {
                await client.Child("Users").PostAsync(new User()
                                            {
                                                Username = uname,
                                                password = passwd
                                            });
                return true;
            }
            else 
            {
                return false;
            }
        }

        public async Task<bool> LoginUser(string uname, string passwd)
        {
            var user = (await client.Child("Users").OnceAsync<User>())
                .Where(u => u.Object.Username == uname)
                .Where(u => u.Object.password == passwd).FirstOrDefault();

            return (user != null);
        }
    }
}
