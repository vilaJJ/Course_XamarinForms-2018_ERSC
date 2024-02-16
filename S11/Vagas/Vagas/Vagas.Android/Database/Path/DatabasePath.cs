using System;
using Vagas.Database.Path.Interfaces;
using Vagas.Droid.Database.Path;
using Xamarin.Forms;

[assembly:Dependency(typeof(DatabasePath))]
namespace Vagas.Droid.Database.Path
{
    public class DatabasePath : IDatabasePath
    {
        public string GetPath(string databaseName)
        {
            var databasePath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            
            var fullPath = System.IO.Path.Combine(databasePath, databaseName);
            return fullPath;
        }
    }
}