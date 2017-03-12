using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FormsAssistControl.Storage.Interfaces;
using SQLite;
using System.IO;
using Xamarin.Forms;
using FormsAssistControl.Droid.Storage.Implementations;

[assembly:Dependency(typeof(SQLiteDroid))]
namespace FormsAssistControl.Droid.Storage.Implementations
{
    public class SQLiteDroid : ISQLite
    {
        public SQLiteDroid()
        {

        }

        public SQLiteConnection GetConnection()
        {
            SQLitePCL.Batteries.Init();
            var sqliteFilename = "TodoSQLite.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath,sqliteFilename);
            // Create the connection
            var conn = new SQLite.SQLiteConnection(path);
            //return the database connection
            return conn;
        }
    }
}