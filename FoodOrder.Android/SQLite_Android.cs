using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FoodOrder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using Environment = System.Environment;
using System.IO;
using Xamarin.Forms;

[assembly:Dependency(typeof(FoodOrder.Droid.SQLite_Android))]
namespace FoodOrder.Droid
{
    public class SQLite_Android : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "MyDatabase.db3";
            string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, sqliteFileName);
            var cn = new SQLiteConnection(path);
            return cn;
        }
    }
}