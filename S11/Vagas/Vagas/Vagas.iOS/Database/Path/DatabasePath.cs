using System;
using Vagas.Database.Path.Interfaces;
using Vagas.iOS.Database.Path;
using Xamarin.Forms;

[assembly: Dependency(typeof(DatabasePath))]
namespace Vagas.iOS.Database.Path
{
    public class DatabasePath : IDatabasePath
    {
        public string GetPath(string databaseName)
        {
            var databasePath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            var libraryPath = System.IO.Path.Combine(databasePath, "..", "Library",databaseName);

            return libraryPath;
        }
    }
}