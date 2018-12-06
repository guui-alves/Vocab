using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using SQLite;
using Vocab.iOS;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(Database_ios))]
namespace Vocab.iOS
{
    public class Database_ios : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            var nomeDB = "Vocab.db3";
            var personalFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string LibraryFolder = Path.Combine(personalFolder, "..", "Library");
            var caminhoDB = Path.Combine(LibraryFolder, nomeDB);
            return new SQLiteConnection(caminhoDB);
        }
    }
}